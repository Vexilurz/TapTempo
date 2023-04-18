using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTempo
{
  public class TempoMemory
  {
    public int tapsCount;
    public List<double> tempoList { get; private set; }

    public TempoMemory(int tapsCount = 0) 
    {  
      this.tapsCount = tapsCount; 
      this.tempoList = new List<double>(); 
    }

    double getLastTempo()
    {
      return tempoList.Count > 0 ? tempoList[tempoList.Count - 1] : 0;
    }

    double getAverage()
    {
      return tempoList.Count > 0 ? tempoList.Average() : 0;
    }

    public override string ToString()
    {
      return $"{tapsCount:d2}: avg={getAverage():f2} last={getLastTempo():f2}";
    }
  }
}
