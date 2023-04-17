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

    private readonly int[] counts;
    private List<DateTime> taps;

    public Tempo(int[] counts)
    {
      taps = new List<DateTime>();
      Array.Sort(counts);
      this.counts = counts;
    }

    public void AddNewTap()
    {
      taps.Add(DateTime.Now);
      if (taps.Count > counts[counts.Length-1]) 
      { 
        taps.RemoveAt(0);
      }
      ListChangedEvent?.Invoke(taps);
    }
  }
}
