public class MathUtil // TypeDefIndex: 9292
{
	// Fields
	public static double EPSILON; // 0x0

	// Methods

	// RVA: 0x2759A50 Offset: 0x2759B51 VA: 0x2759A50
	public static bool AreValuesEqual(double val1, double val2) { }

	// RVA: 0x2759AF0 Offset: 0x2759BF1 VA: 0x2759AF0
	public static bool AreValuesEqual(double val1, double val2, double tolerance) { }

	// RVA: 0x2759B10 Offset: 0x2759C11 VA: 0x2759B10
	public static bool IsValueBetween(double val, double min, double max, double tolerance) { }

	// RVA: 0x2759B50 Offset: 0x2759C51 VA: 0x2759B50
	public static double RoundWithPrecision(double f, double precision) { }

	// RVA: 0x2759BF0 Offset: 0x2759CF1 VA: 0x2759BF0
	public static double Clamp(double a, double low, double high) { }

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D6BF0 Offset: 0x21D6CF1 VA: 0x21D6BF0
	|-MathUtil.Swap<double>
	|
	|-RVA: 0x21D6C10 Offset: 0x21D6D11 VA: 0x21D6C10
	|-MathUtil.Swap<object>
	*/

	// RVA: 0x2759C90 Offset: 0x2759D91 VA: 0x2759C90
	public static uint Jenkins32Hash(byte[] data, uint nInitialValue) { }

	// RVA: 0x2759D00 Offset: 0x2759E01 VA: 0x2759D00
	public void .ctor() { }

	// RVA: 0x2759D10 Offset: 0x2759E11 VA: 0x2759D10
	private static void .cctor() { }
}

