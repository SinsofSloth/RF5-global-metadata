internal class Normalization // TypeDefIndex: 488
{
	// Fields
	private static byte* props; // 0x0
	private static int* mappedChars; // 0x8
	private static short* charMapIndex; // 0x10
	private static short* helperIndex; // 0x18
	private static ushort* mapIdxToComposite; // 0x20
	private static byte* combiningClass; // 0x28
	private static object forLock; // 0x30
	public static readonly bool isReady; // 0x38

	// Methods

	// RVA: 0x2A80390 Offset: 0x2A80491 VA: 0x2A80390
	private static uint PropValue(int cp) { }

	// RVA: 0x2A80430 Offset: 0x2A80531 VA: 0x2A80430
	private static int CharMapIdx(int cp) { }

	// RVA: 0x2A804D0 Offset: 0x2A805D1 VA: 0x2A804D0
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x2A80590 Offset: 0x2A80691 VA: 0x2A80590
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x2A80650 Offset: 0x2A80751 VA: 0x2A80650
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x2A80710 Offset: 0x2A80811 VA: 0x2A80710
	private static string Compose(string source, int checkType) { }

	// RVA: 0x2A80980 Offset: 0x2A80A81 VA: 0x2A80980
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x2A80B20 Offset: 0x2A80C21 VA: 0x2A80B20
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x2A81010 Offset: 0x2A81111 VA: 0x2A81010
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x2A816C0 Offset: 0x2A817C1 VA: 0x2A816C0
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x2A812F0 Offset: 0x2A813F1 VA: 0x2A812F0
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x2A81990 Offset: 0x2A81A91 VA: 0x2A81990
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x2A81BA0 Offset: 0x2A81CA1 VA: 0x2A81BA0
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x2A80820 Offset: 0x2A80921 VA: 0x2A80820
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x2A82010 Offset: 0x2A82111 VA: 0x2A82010
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x2A81C40 Offset: 0x2A81D41 VA: 0x2A81C40
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x2A80C70 Offset: 0x2A80D71 VA: 0x2A80C70
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x2A82690 Offset: 0x2A82791 VA: 0x2A82690
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x2A82320 Offset: 0x2A82421 VA: 0x2A82320
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x2A827A0 Offset: 0x2A828A1 VA: 0x2A827A0
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x2A82950 Offset: 0x2A82A51 VA: 0x2A82950
	public static string Normalize(string source, int type) { }

	// RVA: 0x2A82A90 Offset: 0x2A82B91 VA: 0x2A82A90
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x2A82AA0 Offset: 0x2A82BA1 VA: 0x2A82AA0
	private static void .cctor() { }
}

