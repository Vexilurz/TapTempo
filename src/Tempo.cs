using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTempo
{
  public class Tempo
  {
    public delegate void ListChanged(List<DateTime> taps);
    public event ListChanged ListChangedEvent;

    public delegate void CalculationsChanged(Dictionary<int, double> tempos);
    public event CalculationsChanged CalculationsChangedEvent;

    private readonly int[] counts;
    private List<DateTime> taps;
    private Dictionary<int, List<double>> tempos;

    public Tempo(int[] counts)
    {
      this.counts = counts;
      Array.Sort(this.counts);
      Clear();
    }

    public void Clear()
    {
      taps = new List<DateTime>();
      tempos = new Dictionary<int, List<double>>();
      for (int i = 0; i < counts.Length; i++)
      {
        tempos.Add(counts[i], new List<double>());
      }
      ListChangedEvent?.Invoke(taps);
    }

    public void AddNewTap()
    {
      taps.Add(DateTime.Now);
      if (taps.Count > counts[counts.Length-1]) 
      { 
        taps.RemoveAt(0);
      }
      ListChangedEvent?.Invoke(taps);

      var calculations = Calculate();
      foreach (var c in calculations)
      {
        List<double> d = new List<double>();
        tempos.TryGetValue(c.tapsCount, out d);
        d.Add(c.tempo);
      }
      CalculationsChangedEvent?.Invoke(getAverage());
    }

    Dictionary<int, double> getAverage()
    {
      Dictionary<int, double> result = new Dictionary<int, double>();
      foreach (var t in tempos)
      {
        var avg = t.Value.Count > 0 ? t.Value.Average() : 0;        
        result.Add(t.Key, avg);        
      }
      return result;
    }

    List<TempoDTO> Calculate()
    {
      List<TempoDTO> result = new List<TempoDTO>();
      for (int i = 0; i < counts.Length; i++)
      {        
        var calc = CalculateLastTaps(counts[i]);    
        if (calc.tempo != -1) result.Add(calc);
      }
      return result;
    }

    TempoDTO CalculateLastTaps(int count)
    {
      TempoDTO result = new TempoDTO(count, -1);
      if (taps.Count < count) return result;

      double avg = 0;
      for (int i = taps.Count - 1; i > taps.Count - count; i--)
      {
        var delta = taps[i] - taps[i - 1];
        avg += delta.TotalMilliseconds;
      }
      avg /= count-1;
      result.tempo = getTempoFromDelta(avg);

      return result;
    }

    double getTempoFromDelta(double delta)
    {
      return 60000.0 / delta;
    }
  }
}
