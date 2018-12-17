using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace binaryClock
{
  public partial class Form1 : Form
  {
    System.Threading.Thread t;

    public string hour = DateTime.Now.ToString("HH");
    public string min = DateTime.Now.ToString("mm");
    public string sec = DateTime.Now.ToString("ss");

    public Form1()
    {
      InitializeComponent();
    }

    public void DoThisAllTheTime()
    {   
      Console.WriteLine(hour);
      Console.WriteLine(min);
      Console.WriteLine(sec);

      while (true)
      {
        hour = DateTime.Now.ToString("HH");
        min = DateTime.Now.ToString("mm");
        sec = DateTime.Now.ToString("ss");
        Loop();
        Thread.Sleep(1000);
      }
    }

    public void Loop()
    {
      getBinaryFcol(sec[1]);
      getBinaryEcol(sec[0]);
      getBinaryDcol(min[1]);
      getBinaryCcol(min[0]);
      getBinaryBcol(hour[1]);
      getBinaryAcol(hour[0]);
    }

    public void getBinaryFcol(char x)
    {
      if (x == '0')
      {
        F3.Text = "0";
        F2.Text = "0";
        F1.Text = "0";
        F0.Text = "0";
      }
      else if (x == '1')
      {
        F3.Text = "0";
        F2.Text = "0";
        F1.Text = "0";
        F0.Text = "1";
      }
      else if (x == '2')
      {
        F3.Text = "0";
        F2.Text = "0";
        F1.Text = "1";
        F0.Text = "0";
      }
      else if (x == '3')
      {
        F3.Text = "0";
        F2.Text = "0";
        F1.Text = "1";
        F0.Text = "1";
      }
      else if (x == '4')
      {
        F3.Text = "0";
        F2.Text = "1";
        F1.Text = "0";
        F0.Text = "0";
      }
      else if (x == '5')
      {
        F3.Text = "0";
        F2.Text = "1";
        F1.Text = "0";
        F0.Text = "1";
      }
      else if (x == '6')
      {
        F3.Text = "0";
        F2.Text = "1";
        F1.Text = "1";
        F0.Text = "0";
      }
      else if (x == '7')
      {
        F3.Text = "0";
        F2.Text = "1";
        F1.Text = "1";
        F0.Text = "1";
      }
      else if (x == '8')
      {
        F3.Text = "1";
        F2.Text = "0";
        F1.Text = "0";
        F0.Text = "0";
      }
      else if (x == '9')
      {
        F3.Text = "1";
        F2.Text = "0";
        F1.Text = "0";
        F0.Text = "1";
      }
    }

    public void getBinaryEcol(char x)
    {
      if (x == '0')
      {
        E3.Text = "0";
        E2.Text = "0";
        E1.Text = "0";
        E0.Text = "0";
      }
      else if (x == '1')
      {
        E3.Text = "0";
        E2.Text = "0";
        E1.Text = "0";
        E0.Text = "1";
      }
      else if (x == '2')
      {
        E3.Text = "0";
        E2.Text = "0";
        E1.Text = "1";
        E0.Text = "0";
      }
      else if (x == '3')
      {
        E3.Text = "0";
        E2.Text = "0";
        E1.Text = "1";
        E0.Text = "1";
      }
      else if (x == '4')
      {
        E3.Text = "0";
        E2.Text = "1";
        E1.Text = "0";
        E0.Text = "0";
      }
      else if (x == '5')
      {
        E3.Text = "0";
        E2.Text = "1";
        E1.Text = "0";
        E0.Text = "1";
      }
      else if (x == '6')
      {
        E3.Text = "0";
        E2.Text = "1";
        E1.Text = "1";
        E0.Text = "0";
      }
      else if (x == '7')
      {
        E3.Text = "0";
        E2.Text = "1";
        E1.Text = "1";
        E0.Text = "1";
      }
      else if (x == '8')
      {
        E3.Text = "1";
        E2.Text = "0";
        E1.Text = "0";
        E0.Text = "0";
      }
      else if (x == '9')
      {
        E3.Text = "1";
        E2.Text = "0";
        E1.Text = "0";
        E0.Text = "1";
      }
    }

    public void getBinaryDcol(char x)
    {
      if (x == '0')
      {
        D3.Text = "0";
        D2.Text = "0";
        D1.Text = "0";
        D0.Text = "0";
      }
      else if (x == '1')
      {
        D3.Text = "0";
        D2.Text = "0";
        D1.Text = "0";
        D0.Text = "1";
      }
      else if (x == '2')
      {
        D3.Text = "0";
        D2.Text = "0";
        D1.Text = "1";
        D0.Text = "0";
      }
      else if (x == '3')
      {
        D3.Text = "0";
        D2.Text = "0";
        D1.Text = "1";
        D0.Text = "1";
      }
      else if (x == '4')
      {
        D3.Text = "0";
        D2.Text = "1";
        D1.Text = "0";
        D0.Text = "0";
      }
      else if (x == '5')
      {
        D3.Text = "0";
        D2.Text = "1";
        D1.Text = "0";
        D0.Text = "1";
      }
      else if (x == '6')
      {
        D3.Text = "0";
        D2.Text = "1";
        D1.Text = "1";
        D0.Text = "0";
      }
      else if (x == '7')
      {
        D3.Text = "0";
        D2.Text = "1";
        D1.Text = "1";
        D0.Text = "1";
      }
      else if (x == '8')
      {
        D3.Text = "1";
        D2.Text = "0";
        D1.Text = "0";
        D0.Text = "0";
      }
      else if (x == '9')
      {
        D3.Text = "1";
        D2.Text = "0";
        D1.Text = "0";
        D0.Text = "1";
      }
    }

    public void getBinaryCcol(char x)
    {
      if (x == '0')
      {
        C3.Text = "0";
        C2.Text = "0";
        C1.Text = "0";
        C0.Text = "0";
      }
      else if (x == '1')
      {
        C3.Text = "0";
        C2.Text = "0";
        C1.Text = "0";
        C0.Text = "1";
      }
      else if (x == '2')
      {
        C3.Text = "0";
        C2.Text = "0";
        C1.Text = "1";
        C0.Text = "0";
      }
      else if (x == '3')
      {
        C3.Text = "0";
        C2.Text = "0";
        C1.Text = "1";
        C0.Text = "1";
      }
      else if (x == '4')
      {
        C3.Text = "0";
        C2.Text = "1";
        C1.Text = "0";
        C0.Text = "0";
      }
      else if (x == '5')
      {
        C3.Text = "0";
        C2.Text = "1";
        C1.Text = "0";
        C0.Text = "1";
      }
      else if (x == '6')
      {
        C3.Text = "0";
        C2.Text = "1";
        C1.Text = "1";
        C0.Text = "0";
      }
      else if (x == '7')
      {
        C3.Text = "0";
        C2.Text = "1";
        C1.Text = "1";
        C0.Text = "1";
      }
      else if (x == '8')
      {
        C3.Text = "1";
        C2.Text = "0";
        C1.Text = "0";
        C0.Text = "0";
      }
      else if (x == '9')
      {
        C3.Text = "1";
        C2.Text = "0";
        C1.Text = "0";
        C0.Text = "1";
      }
    }

    public void getBinaryBcol(char x)
    {
      if (x == '0')
      {
        B3.Text = "0";
        B2.Text = "0";
        B1.Text = "0";
        B0.Text = "0";
      }
      else if (x == '1')
      {
        B3.Text = "0";
        B2.Text = "0";
        B1.Text = "0";
        B0.Text = "1";
      }
      else if (x == '2')
      {
        B3.Text = "0";
        B2.Text = "0";
        B1.Text = "1";
        B0.Text = "0";
      }
      else if (x == '3')
      {
        B3.Text = "0";
        B2.Text = "0";
        B1.Text = "1";
        B0.Text = "1";
      }
      else if (x == '4')
      {
        B3.Text = "0";
        B2.Text = "1";
        B1.Text = "0";
        B0.Text = "0";
      }
      else if (x == '5')
      {
        B3.Text = "0";
        B2.Text = "1";
        B1.Text = "0";
        B0.Text = "1";
      }
      else if (x == '6')
      {
        B3.Text = "0";
        B2.Text = "1";
        B1.Text = "1";
        B0.Text = "0";
      }
      else if (x == '7')
      {
        B3.Text = "0";
        B2.Text = "1";
        B1.Text = "1";
        B0.Text = "1";
      }
      else if (x == '8')
      {
        B3.Text = "1";
        B2.Text = "0";
        B1.Text = "0";
        B0.Text = "0";
      }
      else if (x == '9')
      {
        B3.Text = "1";
        B2.Text = "0";
        B1.Text = "0";
        B0.Text = "1";
      }
    }

    public void getBinaryAcol(char x)
    {
      if (x == '0')
      {
        A3.Text = "0";
        A2.Text = "0";
        A1.Text = "0";
        A0.Text = "0";
      }
      else if (x == '1')
      {
        A3.Text = "0";
        A2.Text = "0";
        A1.Text = "0";
        A0.Text = "1";
      }
      else if (x == '2')
      {
        A3.Text = "0";
        A2.Text = "0";
        A1.Text = "1";
        A0.Text = "0";
      }
      else if (x == '3')
      {
        A3.Text = "0";
        A2.Text = "0";
        A1.Text = "1";
        A0.Text = "1";
      }
      else if (x == '4')
      {
        A3.Text = "0";
        A2.Text = "1";
        A1.Text = "0";
        A0.Text = "0";
      }
      else if (x == '5')
      {
        A3.Text = "0";
        A2.Text = "1";
        A1.Text = "0";
        A0.Text = "1";
      }
      else if (x == '6')
      {
        A3.Text = "0";
        A2.Text = "1";
        A1.Text = "1";
        A0.Text = "0";
      }
      else if (x == '7')
      {
        A3.Text = "0";
        A2.Text = "1";
        A1.Text = "1";
        A0.Text = "1";
      }
      else if (x == '8')
      {
        A3.Text = "1";
        A2.Text = "0";
        A1.Text = "0";
        A0.Text = "0";
      }
      else if (x == '9')
      {
        A3.Text = "1";
        A2.Text = "0";
        A1.Text = "0";
        A0.Text = "1";
      }
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      t = new System.Threading.Thread(DoThisAllTheTime);
      t.Start();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      t.Interrupt();
      t.Abort();
    }

    private void Change_color(System.Drawing.Color color)
    {
      A0.ForeColor = color;
      A1.ForeColor = color;
      A2.ForeColor = color;
      A3.ForeColor = color;
      B0.ForeColor = color;
      B1.ForeColor = color;
      B2.ForeColor = color;
      B3.ForeColor = color;
      C0.ForeColor = color;
      C1.ForeColor = color;
      C2.ForeColor = color;
      C3.ForeColor = color;
      D0.ForeColor = color;
      D1.ForeColor = color;
      D2.ForeColor = color;
      D3.ForeColor = color;
      E0.ForeColor = color;
      E1.ForeColor = color;
      E2.ForeColor = color;
      E3.ForeColor = color;
      F0.ForeColor = color;
      F1.ForeColor = color;
      F2.ForeColor = color;
      F3.ForeColor = color;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      List<System.Drawing.Color> color_lst = new List<System.Drawing.Color>(new System.Drawing.Color[] { System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Green, System.Drawing.Color.Orange, System.Drawing.Color.Gray, System.Drawing.Color.Brown, System.Drawing.Color.Snow, System.Drawing.Color.Gold, System.Drawing.Color.Tan, System.Drawing.Color.DarkViolet});

      for (int i = 0; i < color_lst.Count; i++)
      {
        if (A0.ForeColor == color_lst[i])
        {
          if (A0.ForeColor == color_lst[color_lst.Count - 1])
          {
            Change_color(color_lst[0]);
            break;
          }
          else
          {
            Change_color(color_lst[i + 1]);
            break;
          }
        }
      }
    }



  }
}
