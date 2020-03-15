using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Geeksco.Rcxnet;

namespace WindowsController
{
    public partial class MainForm : Form
    {
        private RCXBrick _objBrick = new RCXBrick();
        private bool _isConnected = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _objBrick.CloseComm();
                this._isConnected = false;

                // Update UI
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _objBrick.InitComm();
                _objBrick.BrickType = eBrickType.RCX2;
                this._isConnected = true;
                
                // Update UI
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            int nProgSlots,nOut,nIn,nGlbs,nLcls,nTasks,nSubs,nTmrs,nCntrs,nSmphrs,nRAM;
            int nReqs,nFails,nAborts,nTxReqs,nTxFails,nRxReqs,nRxErrs;


            string strBuffer = string.Empty;
            try
            {
                if (!this._isConnected)
                    return;

                this._objBrick.GetInfo(out nProgSlots,out nOut, out nIn, out nGlbs, out nLcls, out nTasks, out nSubs, out nTmrs, out nCntrs, out nSmphrs, out nRAM);
                this._objBrick.GetStatistics(out nReqs,out nFails, out nAborts, out nTxReqs, out nTxFails, out nRxReqs, out nRxErrs);

                strBuffer += string.Format("General Information\r\n Program Slots: {0}\r\n Outputs: {1}\r\n Inputs: {2}\r\n Globals: {3}\r\n Locals: {4}\r\n Tasks: {5}\r\n Subs: {6}\r\n Timers: {7}\r\n Counters: {8}\r\n Semaphores: {9}\r\n RAM: {10}\r\n",
                    nProgSlots, nOut, nIn, nGlbs, nLcls, nTasks, nSubs, nTmrs, nCntrs, nSmphrs, nRAM);
                strBuffer += string.Format("Statistics\r\n Requests: {0}\r\n Fails: {1}\r\n Aborts: {2}\r\n TxRequests: {3}\r\n TxFails: {4}\r\n RxRequests: {5}\r\n RxErrors: {6}\r\n",
                    nReqs, nFails, nAborts, nTxReqs, nTxFails, nRxReqs, nRxErrs);
                strBuffer += string.Format("Battery Level: {0}\r\n", this._objBrick.PBBattery());
                strBuffer += string.Format("Brick Status: {0}\r\n", this._objBrick.Status(eStatusRequest.BrickStatus));
                strBuffer += string.Format("Free RAM: {0}\r\n", this._objBrick.FreeRAM);
                strBuffer += string.Format("Brick Version: {0}\r\n", this._objBrick.BrickVersion);
                strBuffer += string.Format("Brick Type: {0}\r\n", this._objBrick.BrickType);
                strBuffer += string.Format("Brick Tx Range: {0}\r\n", this._objBrick.BrickTxRange);
                strBuffer += string.Format("Port Name: {0}\r\n", this._objBrick.PortName);
                strBuffer += string.Format("Port Type: {0}\r\n", this._objBrick.PortType);

                txtAllInfo.Text = strBuffer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMotorOn_Click(object sender, EventArgs e)
        {
            eMotorDirection selMotorDir;


            try
            {
                switch(comboDirections.SelectedIndex)
                {
                    case 0:
                        selMotorDir = eMotorDirection.Forward;
                        break;
                    case 1:
                        selMotorDir = eMotorDirection.Invert;
                        break;
                    case 2:
                        selMotorDir = eMotorDirection.Reward;
                        break;
                    default:
                        return;
                }

                switch (comboMotors.SelectedIndex)
                {
                    case 0:
                        _objBrick.MotorA.Direction = selMotorDir;
                        _objBrick.MotorA.Power = (short)numericMotorPower.Value;
                        _objBrick.MotorA.On();
                        break;
                    case 1:
                        _objBrick.MotorB.Direction = selMotorDir;
                        _objBrick.MotorB.Power = (short)numericMotorPower.Value;
                        _objBrick.MotorB.On();
                        break;
                    case 2:
                        _objBrick.MotorC.Direction = selMotorDir;
                        _objBrick.MotorC.Power = (short)numericMotorPower.Value;
                        _objBrick.MotorC.On();
                        break;
                    default:
                        return;
                }

                // Update UI
                btnMotorOff.Enabled = true;
                btnFloat.Enabled = true;
                btnMotorOn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMotorOff_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboMotors.SelectedIndex)
                {
                    case 0:
                        _objBrick.MotorA.Off();
                        break;
                    case 1:
                        _objBrick.MotorB.Off();
                        break;
                    case 2:
                        _objBrick.MotorC.Off();
                        break;
                    default:
                        return;
                }

                // Update UI
                btnMotorOff.Enabled = false;
                btnMotorOn.Enabled = true;
                btnFloat.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnMotorOff.Enabled == false)
                    return;

                switch (comboMotors.SelectedIndex)
                {
                    case 0:
                        _objBrick.MotorA.Float();
                        break;
                    case 1:
                        _objBrick.MotorB.Float();
                        break;
                    case 2:
                        _objBrick.MotorC.Float();
                        break;
                    default:
                        return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPollSensorValue_Click(object sender, EventArgs e)
        {
            try
            {
               switch (comboSensors.SelectedIndex)
                {
                    case 0:
                        _objBrick.Sensor1.SetSensorMode((eSensorMode)numericSensorMode.Value,short.Parse(txtSensorSlope.Text));
                        _objBrick.Sensor1.Type = (eSensorType)comboSensorType.SelectedIndex;
                       MessageBox.Show("Value: "+ _objBrick.Sensor1.Poll(eSensorSource.Boolean).ToString());
                        break;
                    case 1:
                        _objBrick.Sensor2.SetSensorMode((eSensorMode)numericSensorMode.Value,short.Parse(txtSensorSlope.Text));
                        _objBrick.Sensor2.Type = (eSensorType)comboSensorType.SelectedIndex;
                        MessageBox.Show("Value: " + _objBrick.Sensor2.Poll(eSensorSource.Boolean).ToString());
                        break;
                    case 2:
                        _objBrick.Sensor3.SetSensorMode((eSensorMode)numericSensorMode.Value, short.Parse(txtSensorSlope.Text));
                        _objBrick.Sensor3.Type = (eSensorType)comboSensorType.SelectedIndex;
                        MessageBox.Show("Value: " + _objBrick.Sensor3.Poll(eSensorSource.Boolean).ToString());
                        break;
                    default:
                        return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearSensor_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboSensors.SelectedIndex)
                {
                    case 0:
                        _objBrick.Sensor1.ClearSensorValue();
                        break;
                    case 1:
                        _objBrick.Sensor2.ClearSensorValue();
                        break;
                    case 2:
                        _objBrick.Sensor3.ClearSensorValue();
                        break;
                    default:
                        return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlaySysSound_Click(object sender, EventArgs e)
        {
            try
            {
                _objBrick.PlaySystemSound(int.Parse(txtSystemSound.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlayTone_Click(object sender, EventArgs e)
        {
            try
            {
                _objBrick.PlayTone(int.Parse(txtFrecuency.Text),short.Parse(txtTime.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectPrg_Click(object sender, EventArgs e)
        {
            try
            {
                _objBrick.SelectProgram(short.Parse(txtProgram.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {

                switch (comboSensors.SelectedIndex)
                {
                    case 0:
                        _objBrick.Sensor1.SetSensorMode((eSensorMode)numericSensorMode.Value, short.Parse(txtSensorSlope.Text));
                        _objBrick.Sensor1.Type = (eSensorType)comboSensorType.SelectedIndex;
                        _objBrick.Sensor1.SensorValueChanged += new SensorChangedEventHandler(Sensor1_SensorValueChanged);
                        break;
                    case 1:
                        _objBrick.Sensor2.SetSensorMode((eSensorMode)numericSensorMode.Value, short.Parse(txtSensorSlope.Text));
                        _objBrick.Sensor2.Type = (eSensorType)comboSensorType.SelectedIndex;
                        _objBrick.Sensor2.SensorValueChanged += new SensorChangedEventHandler(Sensor2_SensorValueChanged);
                        break;
                    case 2:
                        _objBrick.Sensor3.SetSensorMode((eSensorMode)numericSensorMode.Value, short.Parse(txtSensorSlope.Text));
                        _objBrick.Sensor3.Type = (eSensorType)comboSensorType.SelectedIndex;
                        _objBrick.Sensor3.SensorValueChanged += new SensorChangedEventHandler(Sensor3_SensorValueChanged);
                        break;
                    default:
                        return;
                }
                _objBrick.StartPolling(200);

                startButton.Enabled = false;
                stopButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Sensor3_SensorValueChanged(object sender, SensorChangedEventArgs args)
        {
            MessageBox.Show("Sensor 3 changed, new Value: " + args.Value); 
        }

        void Sensor2_SensorValueChanged(object sender, SensorChangedEventArgs args)
        {
            MessageBox.Show("Sensor 2 changed, new Value: " + args.Value); 
        }

        void Sensor1_SensorValueChanged(object sender, SensorChangedEventArgs args)
        {
            MessageBox.Show("Sensor 1 changed, new Value: " + args.Value); 
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            _objBrick.StopPolling();

            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

       

        

        
    }
}