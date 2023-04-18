using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapTempo
{
  public partial class fmMain : Form
  {
    Tempo tempo; 
    public fmMain()
    {
      InitializeComponent();

      int[] counts = new int[6] { 2, 4, 8, 16, 32, 64 };
      tempo = new Tempo(counts);
      tempo.ListChangedEvent += Tempo_ListChangedEvent;
      tempo.CalculationsReadyEvent += Tempo_CalculationsReadyEvent;
    }

    private void Tempo_CalculationsReadyEvent(List<string> tempos)
    {
      listCalculations.Items.Clear();
      foreach (var t in tempos) 
      {
        listCalculations.Items.Add(t);
      }
    }

    private void Tempo_ListChangedEvent(List<DateTime> taps)
    {
      listLeft.Items.Clear();
      for (int i = taps.Count-1; i >= 0; i--) 
      {
        var t = taps[i];
        var delta = taps[taps.Count-1] - t;
        var sdelta = delta.ToString(@"ss\.ffff");
        listLeft.Items.Add(t.ToString($"[{i:d2}] HH:mm:ss.ffff (+{sdelta})"));
      }
    }

    DateTime lastClick;
    int clicksCount = 0;

    private void bnTap_Click(object sender, EventArgs e)
    {
      clicksCount++;
      sbInfo.Text = $"Taps count: {clicksCount}";
      lastClick = DateTime.Now;
      timerCheck.Enabled = true;
      tempo.AddNewTap();
    }

    void Clear()
    {
      clicksCount = 0;
      tempo.Clear();
    }

    private void bnClear_Click(object sender, EventArgs e)
    {
      Clear();
    }

    private void timerCheck_Tick(object sender, EventArgs e)
    {
      if ((DateTime.Now - lastClick).TotalMilliseconds > 5000) 
      {
        Clear();
        timerCheck.Enabled = false;
      }
    }
  }
}
