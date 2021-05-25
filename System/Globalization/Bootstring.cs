internal class Bootstring // TypeDefIndex: 747
{
	// Fields
	private readonly char delimiter; // 0x10
	private readonly int base_num; // 0x14
	private readonly int tmin; // 0x18
	private readonly int tmax; // 0x1C
	private readonly int skew; // 0x20
	private readonly int damp; // 0x24
	private readonly int initial_bias; // 0x28
	private readonly int initial_n; // 0x2C

	// Methods

	// RVA: 0x17A0020 Offset: 0x17A0121 VA: 0x17A0020
	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	// RVA: 0x17A00A0 Offset: 0x17A01A1 VA: 0x17A00A0
	public string Encode(string s, int offset) { }

	// RVA: 0x17A04B0 Offset: 0x17A05B1 VA: 0x17A04B0
	private char EncodeDigit(int d) { }

	// RVA: 0x17A0550 Offset: 0x17A0651 VA: 0x17A0550
	private int DecodeDigit(char c) { }

	// RVA: 0x17A04D0 Offset: 0x17A05D1 VA: 0x17A04D0
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	// RVA: 0x17A0590 Offset: 0x17A0691 VA: 0x17A0590
	public string Decode(string s, int offset) { }
}

