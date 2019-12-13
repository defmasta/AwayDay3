﻿namespace AwayDay3
{
    partial class Events
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.dtmEventEnd = new System.Windows.Forms.DateTimePicker();
            this.dtmEventStart = new System.Windows.Forms.DateTimePicker();
            this.cbxRequirements = new System.Windows.Forms.CheckedListBox();
            this.txtTotalMembers = new System.Windows.Forms.ComboBox();
            this.txtEventType = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEventCoordinator = new System.Windows.Forms.TextBox();
            this.txtEventname = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEventEnd = new System.Windows.Forms.Label();
            this.lblEventStart = new System.Windows.Forms.Label();
            this.lblRequirements = new System.Windows.Forms.Label();
            this.lblStandardEvents = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEventCoordinator = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblFacilitatedSession = new System.Windows.Forms.Label();
            this.rdbFacilitatedNo = new System.Windows.Forms.RadioButton();
            this.rdbFacilitatedYes = new System.Windows.Forms.RadioButton();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblEstimatedCost = new System.Windows.Forms.Label();
            this.lblDisplayEstimatedCost = new System.Windows.Forms.Label();
            this.lbl3rdPartyServices = new System.Windows.Forms.Label();
            this.txt3rdPartyServices = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAdditionalActivity = new System.Windows.Forms.Label();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.lblAlternateEvents = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.gbxFacilitatedSession = new System.Windows.Forms.GroupBox();
            this.gbxRequirements = new System.Windows.Forms.GroupBox();
            this.gbxEventDate = new System.Windows.Forms.GroupBox();
            this.gbxChoice = new System.Windows.Forms.GroupBox();
            this.gbxEventDetails = new System.Windows.Forms.GroupBox();
            this.gbxAlternateEvents = new System.Windows.Forms.GroupBox();
            this.gbxOutActivity = new System.Windows.Forms.GroupBox();
            this.gbxFacilitatedSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(578, 452);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 42);
            this.btnSubmit.TabIndex = 70;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(436, 180);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(201, 20);
            this.txtLocation.TabIndex = 66;
            // 
            // dtmEventEnd
            // 
            this.dtmEventEnd.Location = new System.Drawing.Point(436, 155);
            this.dtmEventEnd.Name = "dtmEventEnd";
            this.dtmEventEnd.Size = new System.Drawing.Size(200, 20);
            this.dtmEventEnd.TabIndex = 64;
            // 
            // dtmEventStart
            // 
            this.dtmEventStart.Location = new System.Drawing.Point(436, 130);
            this.dtmEventStart.Name = "dtmEventStart";
            this.dtmEventStart.Size = new System.Drawing.Size(200, 20);
            this.dtmEventStart.TabIndex = 63;
            // 
            // cbxRequirements
            // 
            this.cbxRequirements.FormattingEnabled = true;
            this.cbxRequirements.Items.AddRange(new object[] {
            "Staffing",
            "Catering",
            "Security"});
            this.cbxRequirements.Location = new System.Drawing.Point(436, 50);
            this.cbxRequirements.Name = "cbxRequirements";
            this.cbxRequirements.Size = new System.Drawing.Size(200, 49);
            this.cbxRequirements.TabIndex = 62;
            // 
            // txtTotalMembers
            // 
            this.txtTotalMembers.FormattingEnabled = true;
            this.txtTotalMembers.Items.AddRange(new object[] {
            "1 - 10",
            "11 - 30",
            "31 - 50",
            "51 - 100"});
            this.txtTotalMembers.Location = new System.Drawing.Point(134, 235);
            this.txtTotalMembers.Name = "txtTotalMembers";
            this.txtTotalMembers.Size = new System.Drawing.Size(160, 21);
            this.txtTotalMembers.TabIndex = 58;
            // 
            // txtEventType
            // 
            this.txtEventType.FormattingEnabled = true;
            this.txtEventType.Items.AddRange(new object[] {
            "Conference",
            "Seminar",
            "Meeting",
            "Team Building Event",
            "Trade Show",
            "Business Dinner",
            "Golf Event",
            "Incentive Travel",
            "Theme Party",
            "Award Ceremonie"});
            this.txtEventType.Location = new System.Drawing.Point(134, 208);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(160, 21);
            this.txtEventType.TabIndex = 57;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(134, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 20);
            this.txtEmail.TabIndex = 54;
            // 
            // txtEventCoordinator
            // 
            this.txtEventCoordinator.Location = new System.Drawing.Point(134, 156);
            this.txtEventCoordinator.Name = "txtEventCoordinator";
            this.txtEventCoordinator.Size = new System.Drawing.Size(160, 20);
            this.txtEventCoordinator.TabIndex = 53;
            // 
            // txtEventname
            // 
            this.txtEventname.Location = new System.Drawing.Point(134, 130);
            this.txtEventname.Name = "txtEventname";
            this.txtEventname.Size = new System.Drawing.Size(160, 20);
            this.txtEventname.TabIndex = 51;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(406, 205);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 47;
            this.lblCity.Text = "City";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(382, 183);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 46;
            this.lblLocation.Text = "Location";
            // 
            // lblEventEnd
            // 
            this.lblEventEnd.AutoSize = true;
            this.lblEventEnd.Location = new System.Drawing.Point(347, 155);
            this.lblEventEnd.Name = "lblEventEnd";
            this.lblEventEnd.Size = new System.Drawing.Size(83, 13);
            this.lblEventEnd.TabIndex = 45;
            this.lblEventEnd.Text = "Event End Date";
            // 
            // lblEventStart
            // 
            this.lblEventStart.AutoSize = true;
            this.lblEventStart.Location = new System.Drawing.Point(344, 130);
            this.lblEventStart.Name = "lblEventStart";
            this.lblEventStart.Size = new System.Drawing.Size(86, 13);
            this.lblEventStart.TabIndex = 44;
            this.lblEventStart.Text = "Event Start Date";
            // 
            // lblRequirements
            // 
            this.lblRequirements.AutoSize = true;
            this.lblRequirements.Location = new System.Drawing.Point(358, 50);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new System.Drawing.Size(72, 13);
            this.lblRequirements.TabIndex = 43;
            this.lblRequirements.Text = "Requirements";
            // 
            // lblStandardEvents
            // 
            this.lblStandardEvents.AutoSize = true;
            this.lblStandardEvents.Location = new System.Drawing.Point(38, 262);
            this.lblStandardEvents.Name = "lblStandardEvents";
            this.lblStandardEvents.Size = new System.Drawing.Size(86, 13);
            this.lblStandardEvents.TabIndex = 42;
            this.lblStandardEvents.Text = "Standard Events";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Location = new System.Drawing.Point(52, 235);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(77, 13);
            this.lblTotalMembers.TabIndex = 41;
            this.lblTotalMembers.Text = "Total Members";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(67, 208);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(62, 13);
            this.lblEventType.TabIndex = 40;
            this.lblEventType.Text = "Event Type";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(97, 182);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email";
            // 
            // lblEventCoordinator
            // 
            this.lblEventCoordinator.AutoSize = true;
            this.lblEventCoordinator.Location = new System.Drawing.Point(37, 156);
            this.lblEventCoordinator.Name = "lblEventCoordinator";
            this.lblEventCoordinator.Size = new System.Drawing.Size(92, 13);
            this.lblEventCoordinator.TabIndex = 38;
            this.lblEventCoordinator.Text = "Event Coordinator";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(62, 130);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(66, 13);
            this.lblEventName.TabIndex = 37;
            this.lblEventName.Text = "Event Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chocolate producting and marketing",
            "Team building outdoor problem solving",
            "Meditation and mindfulness workshop",
            "Wall climbing experience",
            "Go-cart Experience"});
            this.comboBox1.Location = new System.Drawing.Point(134, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 72;
            this.button1.Text = "Estimate Cost";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(374, 230);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(56, 13);
            this.lblPostCode.TabIndex = 48;
            this.lblPostCode.Text = "Post Code";
            // 
            // lblFacilitatedSession
            // 
            this.lblFacilitatedSession.AutoSize = true;
            this.lblFacilitatedSession.Location = new System.Drawing.Point(61, 50);
            this.lblFacilitatedSession.Name = "lblFacilitatedSession";
            this.lblFacilitatedSession.Size = new System.Drawing.Size(118, 13);
            this.lblFacilitatedSession.TabIndex = 75;
            this.lblFacilitatedSession.Text = "Is it facilitated session? ";
            // 
            // rdbFacilitatedNo
            // 
            this.rdbFacilitatedNo.AutoSize = true;
            this.rdbFacilitatedNo.Location = new System.Drawing.Point(222, 25);
            this.rdbFacilitatedNo.Name = "rdbFacilitatedNo";
            this.rdbFacilitatedNo.Size = new System.Drawing.Size(39, 17);
            this.rdbFacilitatedNo.TabIndex = 77;
            this.rdbFacilitatedNo.TabStop = true;
            this.rdbFacilitatedNo.Text = "No";
            this.rdbFacilitatedNo.UseVisualStyleBackColor = true;
            // 
            // rdbFacilitatedYes
            // 
            this.rdbFacilitatedYes.AutoSize = true;
            this.rdbFacilitatedYes.Location = new System.Drawing.Point(195, 50);
            this.rdbFacilitatedYes.Name = "rdbFacilitatedYes";
            this.rdbFacilitatedYes.Size = new System.Drawing.Size(43, 17);
            this.rdbFacilitatedYes.TabIndex = 76;
            this.rdbFacilitatedYes.TabStop = true;
            this.rdbFacilitatedYes.Text = "Yes";
            this.rdbFacilitatedYes.UseVisualStyleBackColor = true;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(436, 205);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(201, 20);
            this.txtCity.TabIndex = 78;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(436, 230);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(201, 20);
            this.txtPostCode.TabIndex = 79;
            // 
            // lblEstimatedCost
            // 
            this.lblEstimatedCost.AutoSize = true;
            this.lblEstimatedCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedCost.Location = new System.Drawing.Point(332, 471);
            this.lblEstimatedCost.Name = "lblEstimatedCost";
            this.lblEstimatedCost.Size = new System.Drawing.Size(98, 16);
            this.lblEstimatedCost.TabIndex = 80;
            this.lblEstimatedCost.Text = "Estimated Cost";
            this.lblEstimatedCost.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDisplayEstimatedCost
            // 
            this.lblDisplayEstimatedCost.AutoSize = true;
            this.lblDisplayEstimatedCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayEstimatedCost.Location = new System.Drawing.Point(436, 471);
            this.lblDisplayEstimatedCost.Name = "lblDisplayEstimatedCost";
            this.lblDisplayEstimatedCost.Size = new System.Drawing.Size(32, 16);
            this.lblDisplayEstimatedCost.TabIndex = 81;
            this.lblDisplayEstimatedCost.Text = "0.00";
            this.lblDisplayEstimatedCost.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl3rdPartyServices
            // 
            this.lbl3rdPartyServices.AutoSize = true;
            this.lbl3rdPartyServices.Location = new System.Drawing.Point(30, 290);
            this.lbl3rdPartyServices.Name = "lbl3rdPartyServices";
            this.lbl3rdPartyServices.Size = new System.Drawing.Size(93, 13);
            this.lbl3rdPartyServices.TabIndex = 82;
            this.lbl3rdPartyServices.Text = "3rd Party Services";
            // 
            // txt3rdPartyServices
            // 
            this.txt3rdPartyServices.Location = new System.Drawing.Point(134, 290);
            this.txt3rdPartyServices.Name = "txt3rdPartyServices";
            this.txt3rdPartyServices.Size = new System.Drawing.Size(160, 20);
            this.txt3rdPartyServices.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Third Choice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Second Choice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "First Choice";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(436, 334);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 86;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(436, 308);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 85;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(436, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // lblAdditionalActivity
            // 
            this.lblAdditionalActivity.AutoSize = true;
            this.lblAdditionalActivity.Location = new System.Drawing.Point(370, 386);
            this.lblAdditionalActivity.Name = "lblAdditionalActivity";
            this.lblAdditionalActivity.Size = new System.Drawing.Size(267, 13);
            this.lblAdditionalActivity.TabIndex = 59;
            this.lblAdditionalActivity.Text = "Does your program involve any type of outside activity?";
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Location = new System.Drawing.Point(366, 415);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(43, 17);
            this.rdbYes.TabIndex = 60;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "Yes";
            this.rdbYes.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(431, 415);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 61;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // lblAlternateEvents
            // 
            this.lblAlternateEvents.AutoSize = true;
            this.lblAlternateEvents.Location = new System.Drawing.Point(32, 345);
            this.lblAlternateEvents.Name = "lblAlternateEvents";
            this.lblAlternateEvents.Size = new System.Drawing.Size(85, 13);
            this.lblAlternateEvents.TabIndex = 92;
            this.lblAlternateEvents.Text = "Alternate Events";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 361);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 103);
            this.textBox1.TabIndex = 93;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(30, 474);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(95, 13);
            this.lblCost.TabIndex = 90;
            this.lblCost.Text = "Additional Charges";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(135, 469);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(160, 20);
            this.txtCost.TabIndex = 91;
            // 
            // gbxFacilitatedSession
            // 
            this.gbxFacilitatedSession.Controls.Add(this.rdbFacilitatedNo);
            this.gbxFacilitatedSession.Location = new System.Drawing.Point(22, 25);
            this.gbxFacilitatedSession.Name = "gbxFacilitatedSession";
            this.gbxFacilitatedSession.Size = new System.Drawing.Size(281, 74);
            this.gbxFacilitatedSession.TabIndex = 94;
            this.gbxFacilitatedSession.TabStop = false;
            // 
            // gbxRequirements
            // 
            this.gbxRequirements.Location = new System.Drawing.Point(335, 25);
            this.gbxRequirements.Name = "gbxRequirements";
            this.gbxRequirements.Size = new System.Drawing.Size(318, 86);
            this.gbxRequirements.TabIndex = 95;
            this.gbxRequirements.TabStop = false;
            // 
            // gbxEventDate
            // 
            this.gbxEventDate.Location = new System.Drawing.Point(335, 117);
            this.gbxEventDate.Name = "gbxEventDate";
            this.gbxEventDate.Size = new System.Drawing.Size(318, 148);
            this.gbxEventDate.TabIndex = 96;
            this.gbxEventDate.TabStop = false;
            // 
            // gbxChoice
            // 
            this.gbxChoice.Location = new System.Drawing.Point(335, 271);
            this.gbxChoice.Name = "gbxChoice";
            this.gbxChoice.Size = new System.Drawing.Size(318, 96);
            this.gbxChoice.TabIndex = 95;
            this.gbxChoice.TabStop = false;
            // 
            // gbxEventDetails
            // 
            this.gbxEventDetails.Location = new System.Drawing.Point(22, 117);
            this.gbxEventDetails.Name = "gbxEventDetails";
            this.gbxEventDetails.Size = new System.Drawing.Size(281, 211);
            this.gbxEventDetails.TabIndex = 95;
            this.gbxEventDetails.TabStop = false;
            // 
            // gbxAlternateEvents
            // 
            this.gbxAlternateEvents.Location = new System.Drawing.Point(22, 337);
            this.gbxAlternateEvents.Name = "gbxAlternateEvents";
            this.gbxAlternateEvents.Size = new System.Drawing.Size(281, 160);
            this.gbxAlternateEvents.TabIndex = 95;
            this.gbxAlternateEvents.TabStop = false;
            // 
            // gbxOutActivity
            // 
            this.gbxOutActivity.Location = new System.Drawing.Point(335, 373);
            this.gbxOutActivity.Name = "gbxOutActivity";
            this.gbxOutActivity.Size = new System.Drawing.Size(318, 73);
            this.gbxOutActivity.TabIndex = 95;
            this.gbxOutActivity.TabStop = false;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 517);
            this.Controls.Add(this.lblAlternateEvents);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.rdbYes);
            this.Controls.Add(this.lblAdditionalActivity);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt3rdPartyServices);
            this.Controls.Add(this.lbl3rdPartyServices);
            this.Controls.Add(this.lblDisplayEstimatedCost);
            this.Controls.Add(this.lblEstimatedCost);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.rdbFacilitatedYes);
            this.Controls.Add(this.lblFacilitatedSession);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.dtmEventEnd);
            this.Controls.Add(this.dtmEventStart);
            this.Controls.Add(this.cbxRequirements);
            this.Controls.Add(this.txtTotalMembers);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEventCoordinator);
            this.Controls.Add(this.txtEventname);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblEventEnd);
            this.Controls.Add(this.lblEventStart);
            this.Controls.Add(this.lblRequirements);
            this.Controls.Add(this.lblStandardEvents);
            this.Controls.Add(this.lblTotalMembers);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEventCoordinator);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.gbxFacilitatedSession);
            this.Controls.Add(this.gbxRequirements);
            this.Controls.Add(this.gbxEventDate);
            this.Controls.Add(this.gbxChoice);
            this.Controls.Add(this.gbxEventDetails);
            this.Controls.Add(this.gbxAlternateEvents);
            this.Controls.Add(this.gbxOutActivity);
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.btnEstimateCost_Load);
            this.gbxFacilitatedSession.ResumeLayout(false);
            this.gbxFacilitatedSession.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DateTimePicker dtmEventEnd;
        private System.Windows.Forms.DateTimePicker dtmEventStart;
        private System.Windows.Forms.CheckedListBox cbxRequirements;
        private System.Windows.Forms.ComboBox txtTotalMembers;
        private System.Windows.Forms.ComboBox txtEventType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEventCoordinator;
        private System.Windows.Forms.TextBox txtEventname;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEventEnd;
        private System.Windows.Forms.Label lblEventStart;
        private System.Windows.Forms.Label lblRequirements;
        private System.Windows.Forms.Label lblStandardEvents;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEventCoordinator;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblFacilitatedSession;
        private System.Windows.Forms.RadioButton rdbFacilitatedNo;
        private System.Windows.Forms.RadioButton rdbFacilitatedYes;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblEstimatedCost;
        private System.Windows.Forms.Label lblDisplayEstimatedCost;
        private System.Windows.Forms.Label lbl3rdPartyServices;
        private System.Windows.Forms.TextBox txt3rdPartyServices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblAdditionalActivity;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.Label lblAlternateEvents;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.GroupBox gbxFacilitatedSession;
        private System.Windows.Forms.GroupBox gbxRequirements;
        private System.Windows.Forms.GroupBox gbxEventDate;
        private System.Windows.Forms.GroupBox gbxChoice;
        private System.Windows.Forms.GroupBox gbxEventDetails;
        private System.Windows.Forms.GroupBox gbxAlternateEvents;
        private System.Windows.Forms.GroupBox gbxOutActivity;
    }
}