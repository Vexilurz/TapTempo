using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTempo
{
  public class TempoDTO
  {
    public int tapsCount;
    public double tempo;

    public TempoDTO(int tapsCount = 0, double tempo = 0) 
    {  
      this.tapsCount = tapsCount; 
      this.tempo = tempo; 
    }

    public override string ToString()
    {
      return $"{tapsCount:d2}: {tempo:f2}";
    }
  }
}
