internal sealed class RegexInterpreter : RegexRunner // TypeDefIndex: 1783
{
	// Fields
	internal int runoperator; // 0x80
	internal int[] runcodes; // 0x88
	internal int runcodepos; // 0x90
	internal string[] runstrings; // 0x98
	internal RegexCode runcode; // 0xA0
	internal RegexPrefix runfcPrefix; // 0xA8
	internal RegexBoyerMoore runbmPrefix; // 0xB0
	internal int runanchors; // 0xB8
	internal bool runrtl; // 0xBC
	internal bool runci; // 0xBD
	internal CultureInfo runculture; // 0xC0

	// Methods

	// RVA: 0x1618370 Offset: 0x1618471 VA: 0x1618370
	internal void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x1618420 Offset: 0x1618521 VA: 0x1618420 Slot: 6
	protected override void InitTrackCount() { }

	// RVA: 0x1618440 Offset: 0x1618541 VA: 0x1618440
	private void Advance() { }

	// RVA: 0x16184B0 Offset: 0x16185B1 VA: 0x16184B0
	private void Advance(int i) { }

	// RVA: 0x1618540 Offset: 0x1618641 VA: 0x1618540
	private void Goto(int newpos) { }

	// RVA: 0x1618650 Offset: 0x1618751 VA: 0x1618650
	private void Textto(int newpos) { }

	// RVA: 0x1618660 Offset: 0x1618761 VA: 0x1618660
	private void Trackto(int newpos) { }

	// RVA: 0x1618690 Offset: 0x1618791 VA: 0x1618690
	private int Textstart() { }

	// RVA: 0x16186A0 Offset: 0x16187A1 VA: 0x16186A0
	private int Textpos() { }

	// RVA: 0x16186B0 Offset: 0x16187B1 VA: 0x16186B0
	private int Trackpos() { }

	// RVA: 0x16186E0 Offset: 0x16187E1 VA: 0x16186E0
	private void TrackPush() { }

	// RVA: 0x1618730 Offset: 0x1618831 VA: 0x1618730
	private void TrackPush(int I1) { }

	// RVA: 0x16187B0 Offset: 0x16188B1 VA: 0x16187B0
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x1618850 Offset: 0x1618951 VA: 0x1618850
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x1618920 Offset: 0x1618A21 VA: 0x1618920
	private void TrackPush2(int I1) { }

	// RVA: 0x16189A0 Offset: 0x1618AA1 VA: 0x16189A0
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x1618A40 Offset: 0x1618B41 VA: 0x1618A40
	private void Backtrack() { }

	// RVA: 0x1618520 Offset: 0x1618621 VA: 0x1618520
	private void SetOperator(int op) { }

	// RVA: 0x1618B70 Offset: 0x1618C71 VA: 0x1618B70
	private void TrackPop() { }

	// RVA: 0x1618B80 Offset: 0x1618C81 VA: 0x1618B80
	private void TrackPop(int framesize) { }

	// RVA: 0x1618B90 Offset: 0x1618C91 VA: 0x1618B90
	private int TrackPeek() { }

	// RVA: 0x1618BE0 Offset: 0x1618CE1 VA: 0x1618BE0
	private int TrackPeek(int i) { }

	// RVA: 0x1618C30 Offset: 0x1618D31 VA: 0x1618C30
	private void StackPush(int I1) { }

	// RVA: 0x1618C80 Offset: 0x1618D81 VA: 0x1618C80
	private void StackPush(int I1, int I2) { }

	// RVA: 0x1618CF0 Offset: 0x1618DF1 VA: 0x1618CF0
	private void StackPop() { }

	// RVA: 0x1618D00 Offset: 0x1618E01 VA: 0x1618D00
	private void StackPop(int framesize) { }

	// RVA: 0x1618D10 Offset: 0x1618E11 VA: 0x1618D10
	private int StackPeek() { }

	// RVA: 0x1618D60 Offset: 0x1618E61 VA: 0x1618D60
	private int StackPeek(int i) { }

	// RVA: 0x1618DB0 Offset: 0x1618EB1 VA: 0x1618DB0
	private int Operator() { }

	// RVA: 0x1618DC0 Offset: 0x1618EC1 VA: 0x1618DC0
	private int Operand(int i) { }

	// RVA: 0x1618E10 Offset: 0x1618F11 VA: 0x1618E10
	private int Leftchars() { }

	// RVA: 0x1618E20 Offset: 0x1618F21 VA: 0x1618E20
	private int Rightchars() { }

	// RVA: 0x1618E30 Offset: 0x1618F31 VA: 0x1618E30
	private int Bump() { }

	// RVA: 0x1618E50 Offset: 0x1618F51 VA: 0x1618E50
	private int Forwardchars() { }

	// RVA: 0x1618E80 Offset: 0x1618F81 VA: 0x1618E80
	private char Forwardcharnext() { }

	// RVA: 0x1618F40 Offset: 0x1619041 VA: 0x1618F40
	private bool Stringmatch(string str) { }

	// RVA: 0x16190E0 Offset: 0x16191E1 VA: 0x16190E0
	private bool Refmatch(int index, int len) { }

	// RVA: 0x1619290 Offset: 0x1619391 VA: 0x1619290
	private void Backwardnext() { }

	// RVA: 0x16192C0 Offset: 0x16193C1 VA: 0x16192C0
	private char CharAt(int j) { }

	// RVA: 0x16192E0 Offset: 0x16193E1 VA: 0x16192E0 Slot: 5
	protected override bool FindFirstChar() { }

	// RVA: 0x1619700 Offset: 0x1619801 VA: 0x1619700 Slot: 4
	protected override void Go() { }
}

