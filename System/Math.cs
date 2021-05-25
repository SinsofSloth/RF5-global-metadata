public static class Math // TypeDefIndex: 275
{
	// Fields
	private static double doubleRoundLimit; // 0x0
	private const int maxRoundingDigits = 15;
	private static double[] roundPower10Double; // 0x8
	public const double PI = 3.141592653589793;
	public const double E = 2.718281828459045;

	// Methods

	// RVA: 0x18DC3C0 Offset: 0x18DC4C1 VA: 0x18DC3C0
	public static double Acos(double d) { }

	// RVA: 0x18DC3D0 Offset: 0x18DC4D1 VA: 0x18DC3D0
	public static double Asin(double d) { }

	// RVA: 0x18DC3E0 Offset: 0x18DC4E1 VA: 0x18DC3E0
	public static double Atan(double d) { }

	// RVA: 0x18DC3F0 Offset: 0x18DC4F1 VA: 0x18DC3F0
	public static double Atan2(double y, double x) { }

	// RVA: 0x18DC400 Offset: 0x18DC501 VA: 0x18DC400
	public static double Ceiling(double a) { }

	// RVA: 0x18DC410 Offset: 0x18DC511 VA: 0x18DC410
	public static double Cos(double d) { }

	// RVA: 0x18DC420 Offset: 0x18DC521 VA: 0x18DC420
	public static double Floor(double d) { }

	// RVA: 0x18DC430 Offset: 0x18DC531 VA: 0x18DC430
	private static double InternalRound(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x18DC7A0 Offset: 0x18DC8A1 VA: 0x18DC7A0
	private static double InternalTruncate(double d) { }

	// RVA: 0x18DC810 Offset: 0x18DC911 VA: 0x18DC810
	public static double Sin(double a) { }

	// RVA: 0x18DC820 Offset: 0x18DC921 VA: 0x18DC820
	public static double Tan(double a) { }

	// RVA: 0x18DC830 Offset: 0x18DC931 VA: 0x18DC830
	public static double Round(double a) { }

	// RVA: 0x18DC8D0 Offset: 0x18DC9D1 VA: 0x18DC8D0
	public static double Round(double value, int digits) { }

	// RVA: 0x18DC9B0 Offset: 0x18DCAB1 VA: 0x18DC9B0
	public static double Round(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x18DCB80 Offset: 0x18DCC81 VA: 0x18DCB80
	public static Decimal Round(Decimal d, int decimals, MidpointRounding mode) { }

	// RVA: 0x18DC6B0 Offset: 0x18DC7B1 VA: 0x18DC6B0
	private static double SplitFractionDouble(double* value) { }

	// RVA: 0x18DCC10 Offset: 0x18DCD11 VA: 0x18DCC10
	public static double Truncate(double d) { }

	[ReliabilityContractAttribute] // RVA: 0xB6AA0 Offset: 0xB6BA1 VA: 0xB6AA0
	// RVA: 0x18DCCE0 Offset: 0x18DCDE1 VA: 0x18DCCE0
	public static double Sqrt(double d) { }

	// RVA: 0x18DCD00 Offset: 0x18DCE01 VA: 0x18DCD00
	public static double Log(double d) { }

	// RVA: 0x18DCD10 Offset: 0x18DCE11 VA: 0x18DCD10
	public static double Log10(double d) { }

	// RVA: 0x18DCD20 Offset: 0x18DCE21 VA: 0x18DCD20
	public static double Exp(double d) { }

	// RVA: 0x18DCD30 Offset: 0x18DCE31 VA: 0x18DCD30
	public static double Pow(double x, double y) { }

	// RVA: 0x18DCD40 Offset: 0x18DCE41 VA: 0x18DCD40
	public static double IEEERemainder(double x, double y) { }

	// RVA: 0x18DD070 Offset: 0x18DD171 VA: 0x18DD070
	public static int Abs(int value) { }

	// RVA: 0x18DD170 Offset: 0x18DD271 VA: 0x18DD170
	private static int AbsHelper(int value) { }

	// RVA: 0x18DD210 Offset: 0x18DD311 VA: 0x18DD210
	public static float Abs(float value) { }

	// RVA: 0x18DD220 Offset: 0x18DD321 VA: 0x18DD220
	public static double Abs(double value) { }

	[ReliabilityContractAttribute] // RVA: 0xB6AC0 Offset: 0xB6BC1 VA: 0xB6AC0
	// RVA: 0x18DD230 Offset: 0x18DD331 VA: 0x18DD230
	public static int Max(int val1, int val2) { }

	[ReliabilityContractAttribute] // RVA: 0xB6AE0 Offset: 0xB6BE1 VA: 0xB6AE0
	[CLSCompliantAttribute] // RVA: 0xB6AE0 Offset: 0xB6BE1 VA: 0xB6AE0
	// RVA: 0x18DD240 Offset: 0x18DD341 VA: 0x18DD240
	public static uint Max(uint val1, uint val2) { }

	[ReliabilityContractAttribute] // RVA: 0xB6B30 Offset: 0xB6C31 VA: 0xB6B30
	// RVA: 0x18DD250 Offset: 0x18DD351 VA: 0x18DD250
	public static long Max(long val1, long val2) { }

	[ReliabilityContractAttribute] // RVA: 0xB6B50 Offset: 0xB6C51 VA: 0xB6B50
	// RVA: 0x18DD260 Offset: 0x18DD361 VA: 0x18DD260
	public static float Max(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0xB6B70 Offset: 0xB6C71 VA: 0xB6B70
	// RVA: 0x18DD2B0 Offset: 0x18DD3B1 VA: 0x18DD2B0
	public static double Max(double val1, double val2) { }

	[ReliabilityContractAttribute] // RVA: 0xB6B90 Offset: 0xB6C91 VA: 0xB6B90
	// RVA: 0x18DD350 Offset: 0x18DD451 VA: 0x18DD350
	public static int Min(int val1, int val2) { }

	[ReliabilityContractAttribute] // RVA: 0xB6BB0 Offset: 0xB6CB1 VA: 0xB6BB0
	// RVA: 0x18DD360 Offset: 0x18DD461 VA: 0x18DD360
	public static long Min(long val1, long val2) { }

	[ReliabilityContractAttribute] // RVA: 0xB6BD0 Offset: 0xB6CD1 VA: 0xB6BD0
	// RVA: 0x18DD370 Offset: 0x18DD471 VA: 0x18DD370
	public static float Min(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0xB6BF0 Offset: 0xB6CF1 VA: 0xB6BF0
	// RVA: 0x18DD3C0 Offset: 0x18DD4C1 VA: 0x18DD3C0
	public static double Min(double val1, double val2) { }

	// RVA: 0x18DD460 Offset: 0x18DD561 VA: 0x18DD460
	public static double Log(double a, double newBase) { }

	// RVA: 0x18DD5D0 Offset: 0x18DD6D1 VA: 0x18DD5D0
	public static int Sign(float value) { }

	// RVA: 0x18DC6C0 Offset: 0x18DC7C1 VA: 0x18DC6C0
	public static int Sign(double value) { }

	// RVA: 0x18DD6B0 Offset: 0x18DD7B1 VA: 0x18DD6B0
	private static void .cctor() { }
}

