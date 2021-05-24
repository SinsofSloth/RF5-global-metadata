[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 3400
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Methods

	// RVA: 0x22620 Offset: 0x22721 VA: 0x22620
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0xE09C0 Offset: 0xE0AC1 VA: 0xE09C0
	// RVA: 0x226C0 Offset: 0x227C1 VA: 0x226C0
	public void .ctor(byte[] value) { }

	// RVA: 0x226D0 Offset: 0x227D1 VA: 0x226D0
	public void .ctor(ReadOnlySpan<byte> value) { }

	// RVA: 0x22710 Offset: 0x22811 VA: 0x22710
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x22720 Offset: 0x22821 VA: 0x22720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22780 Offset: 0x22881 VA: 0x22780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22790 Offset: 0x22891 VA: 0x22790 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x228E0 Offset: 0x229E1 VA: 0x228E0 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x228F0 Offset: 0x229F1 VA: 0x228F0 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x22900 Offset: 0x22A01 VA: 0x22900
	public byte[] ToByteArray() { }

	// RVA: 0x22940 Offset: 0x22A41 VA: 0x22940
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, ref int bytesWritten) { }

	// RVA: 0x22980 Offset: 0x22A81 VA: 0x22980 Slot: 3
	public override string ToString() { }

	// RVA: 0x229C0 Offset: 0x22AC1 VA: 0x229C0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1BA40F0 Offset: 0x1BA41F1 VA: 0x1BA40F0
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x1BA5360 Offset: 0x1BA5461 VA: 0x1BA5360
	private static void .cctor() { }
}

[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 3400
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Methods

	// RVA: 0x22620 Offset: 0x22721 VA: 0x22620
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0xE09C0 Offset: 0xE0AC1 VA: 0xE09C0
	// RVA: 0x226C0 Offset: 0x227C1 VA: 0x226C0
	public void .ctor(byte[] value) { }

	// RVA: 0x226D0 Offset: 0x227D1 VA: 0x226D0
	public void .ctor(ReadOnlySpan<byte> value) { }

	// RVA: 0x22710 Offset: 0x22811 VA: 0x22710
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x22720 Offset: 0x22821 VA: 0x22720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22780 Offset: 0x22881 VA: 0x22780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22790 Offset: 0x22891 VA: 0x22790 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x228E0 Offset: 0x229E1 VA: 0x228E0 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x228F0 Offset: 0x229F1 VA: 0x228F0 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x22900 Offset: 0x22A01 VA: 0x22900
	public byte[] ToByteArray() { }

	// RVA: 0x22940 Offset: 0x22A41 VA: 0x22940
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, ref int bytesWritten) { }

	// RVA: 0x22980 Offset: 0x22A81 VA: 0x22980 Slot: 3
	public override string ToString() { }

	// RVA: 0x229C0 Offset: 0x22AC1 VA: 0x229C0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1BA40F0 Offset: 0x1BA41F1 VA: 0x1BA40F0
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x1BA5360 Offset: 0x1BA5461 VA: 0x1BA5360
	private static void .cctor() { }
}

[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 3400
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Methods

	// RVA: 0x22620 Offset: 0x22721 VA: 0x22620
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0xE09C0 Offset: 0xE0AC1 VA: 0xE09C0
	// RVA: 0x226C0 Offset: 0x227C1 VA: 0x226C0
	public void .ctor(byte[] value) { }

	// RVA: 0x226D0 Offset: 0x227D1 VA: 0x226D0
	public void .ctor(ReadOnlySpan<byte> value) { }

	// RVA: 0x22710 Offset: 0x22811 VA: 0x22710
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x22720 Offset: 0x22821 VA: 0x22720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22780 Offset: 0x22881 VA: 0x22780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22790 Offset: 0x22891 VA: 0x22790 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x228E0 Offset: 0x229E1 VA: 0x228E0 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x228F0 Offset: 0x229F1 VA: 0x228F0 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x22900 Offset: 0x22A01 VA: 0x22900
	public byte[] ToByteArray() { }

	// RVA: 0x22940 Offset: 0x22A41 VA: 0x22940
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, ref int bytesWritten) { }

	// RVA: 0x22980 Offset: 0x22A81 VA: 0x22980 Slot: 3
	public override string ToString() { }

	// RVA: 0x229C0 Offset: 0x22AC1 VA: 0x229C0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1BA40F0 Offset: 0x1BA41F1 VA: 0x1BA40F0
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x1BA5360 Offset: 0x1BA5461 VA: 0x1BA5360
	private static void .cctor() { }
}

[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 3400
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Methods

	// RVA: 0x22620 Offset: 0x22721 VA: 0x22620
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0xE09C0 Offset: 0xE0AC1 VA: 0xE09C0
	// RVA: 0x226C0 Offset: 0x227C1 VA: 0x226C0
	public void .ctor(byte[] value) { }

	// RVA: 0x226D0 Offset: 0x227D1 VA: 0x226D0
	public void .ctor(ReadOnlySpan<byte> value) { }

	// RVA: 0x22710 Offset: 0x22811 VA: 0x22710
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x22720 Offset: 0x22821 VA: 0x22720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22780 Offset: 0x22881 VA: 0x22780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22790 Offset: 0x22891 VA: 0x22790 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x228E0 Offset: 0x229E1 VA: 0x228E0 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x228F0 Offset: 0x229F1 VA: 0x228F0 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x22900 Offset: 0x22A01 VA: 0x22900
	public byte[] ToByteArray() { }

	// RVA: 0x22940 Offset: 0x22A41 VA: 0x22940
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, ref int bytesWritten) { }

	// RVA: 0x22980 Offset: 0x22A81 VA: 0x22980 Slot: 3
	public override string ToString() { }

	// RVA: 0x229C0 Offset: 0x22AC1 VA: 0x229C0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1BA40F0 Offset: 0x1BA41F1 VA: 0x1BA40F0
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x1BA5360 Offset: 0x1BA5461 VA: 0x1BA5360
	private static void .cctor() { }
}

[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 3400
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Methods

	// RVA: 0x22620 Offset: 0x22721 VA: 0x22620
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0xE09C0 Offset: 0xE0AC1 VA: 0xE09C0
	// RVA: 0x226C0 Offset: 0x227C1 VA: 0x226C0
	public void .ctor(byte[] value) { }

	// RVA: 0x226D0 Offset: 0x227D1 VA: 0x226D0
	public void .ctor(ReadOnlySpan<byte> value) { }

	// RVA: 0x22710 Offset: 0x22811 VA: 0x22710
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x22720 Offset: 0x22821 VA: 0x22720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22780 Offset: 0x22881 VA: 0x22780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22790 Offset: 0x22891 VA: 0x22790 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x228E0 Offset: 0x229E1 VA: 0x228E0 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x228F0 Offset: 0x229F1 VA: 0x228F0 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x22900 Offset: 0x22A01 VA: 0x22900
	public byte[] ToByteArray() { }

	// RVA: 0x22940 Offset: 0x22A41 VA: 0x22940
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, ref int bytesWritten) { }

	// RVA: 0x22980 Offset: 0x22A81 VA: 0x22980 Slot: 3
	public override string ToString() { }

	// RVA: 0x229C0 Offset: 0x22AC1 VA: 0x229C0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1BA40F0 Offset: 0x1BA41F1 VA: 0x1BA40F0
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x1BA5360 Offset: 0x1BA5461 VA: 0x1BA5360
	private static void .cctor() { }
}

[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 3400
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Methods

	// RVA: 0x22620 Offset: 0x22721 VA: 0x22620
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0xE09C0 Offset: 0xE0AC1 VA: 0xE09C0
	// RVA: 0x226C0 Offset: 0x227C1 VA: 0x226C0
	public void .ctor(byte[] value) { }

	// RVA: 0x226D0 Offset: 0x227D1 VA: 0x226D0
	public void .ctor(ReadOnlySpan<byte> value) { }

	// RVA: 0x22710 Offset: 0x22811 VA: 0x22710
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x22720 Offset: 0x22821 VA: 0x22720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22780 Offset: 0x22881 VA: 0x22780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22790 Offset: 0x22891 VA: 0x22790 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x228E0 Offset: 0x229E1 VA: 0x228E0 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x228F0 Offset: 0x229F1 VA: 0x228F0 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x22900 Offset: 0x22A01 VA: 0x22900
	public byte[] ToByteArray() { }

	// RVA: 0x22940 Offset: 0x22A41 VA: 0x22940
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, ref int bytesWritten) { }

	// RVA: 0x22980 Offset: 0x22A81 VA: 0x22980 Slot: 3
	public override string ToString() { }

	// RVA: 0x229C0 Offset: 0x22AC1 VA: 0x229C0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1BA40F0 Offset: 0x1BA41F1 VA: 0x1BA40F0
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x1BA5360 Offset: 0x1BA5461 VA: 0x1BA5360
	private static void .cctor() { }
}

[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 3400
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Methods

	// RVA: 0x22620 Offset: 0x22721 VA: 0x22620
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0xE09C0 Offset: 0xE0AC1 VA: 0xE09C0
	// RVA: 0x226C0 Offset: 0x227C1 VA: 0x226C0
	public void .ctor(byte[] value) { }

	// RVA: 0x226D0 Offset: 0x227D1 VA: 0x226D0
	public void .ctor(ReadOnlySpan<byte> value) { }

	// RVA: 0x22710 Offset: 0x22811 VA: 0x22710
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x22720 Offset: 0x22821 VA: 0x22720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22780 Offset: 0x22881 VA: 0x22780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22790 Offset: 0x22891 VA: 0x22790 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x228E0 Offset: 0x229E1 VA: 0x228E0 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x228F0 Offset: 0x229F1 VA: 0x228F0 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x22900 Offset: 0x22A01 VA: 0x22900
	public byte[] ToByteArray() { }

	// RVA: 0x22940 Offset: 0x22A41 VA: 0x22940
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, ref int bytesWritten) { }

	// RVA: 0x22980 Offset: 0x22A81 VA: 0x22980 Slot: 3
	public override string ToString() { }

	// RVA: 0x229C0 Offset: 0x22AC1 VA: 0x229C0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1BA40F0 Offset: 0x1BA41F1 VA: 0x1BA40F0
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x1BA5360 Offset: 0x1BA5461 VA: 0x1BA5360
	private static void .cctor() { }
}

