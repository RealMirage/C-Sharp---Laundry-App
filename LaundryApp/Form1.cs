using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Speech.Synthesis;



namespace LaundryApp
{
    public partial class FrmMain : Form
    {

        private int _washStop;
        private int _washTicks;
        private int _dryTicks;
        private int _dryStop;
        private int _washerTimeSetting;
        private int _dryerTimeSetting;
        private int _cyclesInput;
        private int _cyclesCompleteWash = 0;
        private int _cyclesCompleteDryer = 0;
        private static SpeechSynthesizer synth = new SpeechSynthesizer();

        public int GetTimeRemaining(int wSetting, int dSetting, int cycles)
        {
            return wSetting + cycles * dSetting;
        }

        public int GetSecondsFromMinutes(int m)
        {
            return 60 * m;
        }

        public int GetIntFromText(string s)
        {
            return Convert.ToInt16(s);
        }

        public void SetTimeRemaining(Label obj, string val)
        {
            obj.Text = val;
        }

        public string GetTimeFromSeconds(int inputSeconds)
        {
            int hours, minutes, seconds;
            if (inputSeconds >= 3600)
            {
                hours = inputSeconds / 3600;
                minutes = (inputSeconds - 3600 * hours)/60;
                seconds = inputSeconds - 3600 * hours - 60 * minutes;
                return hours.ToString() + " H, " + minutes.ToString() + " M, " + seconds.ToString() + " S.";
            }
            else if (inputSeconds >=  60)
            {
                minutes = inputSeconds / 60;
                seconds = inputSeconds - minutes * 60;
                return minutes.ToString() + " minutes, " + seconds.ToString() + " seconds";
            }
            else
            {
                return inputSeconds.ToString() + " seconds.";
            }
        }

        public static void Speak(string message, VoiceGender voiceGender, int rate)
        {
            synth.Rate = rate;
            synth.SelectVoiceByHints(voiceGender);
            synth.Speak(message);
        }


        public FrmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void washCycleTimeSetting_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Initialize time-settings.
            _washerTimeSetting = GetIntFromText(tWasherTimeSetting.Text);
            _dryerTimeSetting = GetIntFromText(tDryerTimeSetting.Text);

            if (tNumberOfCycles.Text.Length == 0)
            {
                _cyclesInput = 1;
            }
            else
            {
                _cyclesInput = GetIntFromText(tNumberOfCycles.Text);
            }



            //Calculates time left in seconds based upon setting user put in (input should be in minutes).
            _washStop = GetSecondsFromMinutes(_washerTimeSetting);
            _dryStop = GetSecondsFromMinutes(_dryerTimeSetting);

            if (tiWasherTimeRemaining.Enabled == false && _cyclesCompleteWash != _cyclesInput)
            {
                tiWasherTimeRemaining.Enabled = true;
                tiWasherTimeRemaining.Start();
                _washTicks = 0;
            }
            if (tiDryerTimeRemaining.Enabled == false && _cyclesCompleteWash >= 1 && _cyclesCompleteDryer != _cyclesInput)
            {
                tiDryerTimeRemaining.Enabled = true;
                tiDryerTimeRemaining.Start();
                _dryTicks = 0;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tiWasherTimeRemaining_Tick(object sender, EventArgs e)
        {
            //Counts up & displays remaining time until there's no more to display!
            _washTicks++;
            if (_washStop > _washTicks - 1)
            {
                 SetTimeRemaining(lblWasherTimeRemaining, GetTimeFromSeconds(_washStop - _washTicks));
            }
            else //If we've hit the amount of time in the cycle (or higher), perform checks.
            {
                //Increment variable for wash cycles completed:
                _cyclesCompleteWash++;

                //Then speak to user if it's 1st cycle (nothing in dryer yet). If it's more than 1st cycle complete we don't want to do that. Dryer takes longer.
                if (_cyclesCompleteWash == 1)
                {
                    Speak("Your washer is done, change your laundry and hit the start button.", VoiceGender.Male, 3);
                }
                else
                {
                    //Check and see if the washer takes longer than the dryer. If so, speak to the user. Otherwise do nothing.
                    if (_washerTimeSetting > _dryerTimeSetting)
                    {
                        Speak("Your washer is done, change your loads.", VoiceGender.Male, 3);
                    }
                }

                //Then shut washer timer off.
                tiWasherTimeRemaining.Enabled = false;
            }

            //Way to stop counter.
            if (_cyclesInput.ToString() != tNumberOfCycles.Text && tNumberOfCycles.Text.Length > 0)
            {
                 tiWasherTimeRemaining.Stop();
            }

            
        }

        private void tiDryerTimeRemaining_Tick(object sender, EventArgs e)
        {

                _dryTicks++;
                if (_dryStop > _dryTicks - 1)
                {
                    SetTimeRemaining(lblDryerTimeRemaining, GetTimeFromSeconds(_dryStop - _dryTicks));
                }
                else
                {
                    _cyclesCompleteDryer++;
                    if (_dryerTimeSetting >= _washerTimeSetting)
                    {
                        Speak("Your dryer is done, change your loads.", VoiceGender.Male, 3);
                    }
                    else
                    {
                        if(_cyclesCompleteDryer == _cyclesInput)
                        {
                            Speak("Your dryer is done!", VoiceGender.Male, 3);
                        }
                    }
                    tiDryerTimeRemaining.Enabled = false;
                }
               

                if (_cyclesInput.ToString() != tNumberOfCycles.Text & tNumberOfCycles.Text.Length > 0)
                {
                    tiDryerTimeRemaining.Stop();
                }
        }
   }
}

