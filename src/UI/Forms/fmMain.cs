﻿using System;
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

      int[] counts = new int[4] { 4, 8, 16, 32 };
      tempo = new Tempo(counts);
      tempo.ListChangedEvent += Tempo_ListChangedEvent;
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

    private void bnTap_Click(object sender, EventArgs e)
    {
      tempo.AddNewTap();
    }
  }
}
