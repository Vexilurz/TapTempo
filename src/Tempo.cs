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

    public delegate void CalculationsReady(List<string> tempos);
    public event CalculationsReady CalculationsReadyEvent;

    private readonly int[] counts;
    private List<DateTime> taps;
    private List<TempoMemory> tempos;

    public Tempo(int[] counts)
    {
      this.counts = counts;
      Array.Sort(this.counts);
      Clear();
    }

    public void Clear()
    {
      taps = new List<DateTime>();
      tempos = new List<TempoMemory>();
      for (int i = 0; i < counts.Length; i++)
      {
        tempos.Add(new TempoMemory(counts[i]));
      }
      ListChangedEvent?.Invoke(taps);
    }

    List<double> getListFromTapsCount(int tapsCount)
    {
      foreach (var t in tempos)
      {
        if (t.tapsCount == tapsCount) return t.tempoList;
      }
      return new List<double>();
    }

    public void AddNewTap()
    {
      taps.Add(DateTime.Now);
      if (taps.Count > counts[counts.Length-1]) 
      { 
        taps.RemoveAt(0);
      }
      ListChangedEvent?.Invoke(taps);

      Calculate();
      List<string> list = new List<string>(); 
      foreach (var t in tempos)
      {
        list.Add(t.ToString());
      }
      CalculationsReadyEvent?.Invoke(list);
    }

    void Calculate()
    {
      for (int i = 0; i < counts.Length; i++)
      {        
        var tempo = CalculateTempoFromLastTaps(counts[i]);
        if (tempo != -1)
        {
          var list = getListFromTapsCount(counts[i]);
          list.Add(tempo);
        }
      }
    }

    double CalculateTempoFromLastTaps(int count)
    {
      double result = -1;
      if (taps.Count < count) return result;

      double avg = 0;
      for (int i = taps.Count - 1; i > taps.Count - count; i--)
      {
        var delta = taps[i] - taps[i - 1];
        avg += delta.TotalMilliseconds;
      }
      avg /= count-1;
      result = getTempoFromDelta(avg);

      return result;
    }

    double getTempoFromDelta(double delta)
    {
      return 60000.0 / delta;
    }
  }
}
