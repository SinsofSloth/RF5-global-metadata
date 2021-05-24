internal static class TimeUtility // TypeDefIndex: 4635
{
	// Fields
	public static readonly double kTimeEpsilon; // 0x0
	public static readonly double kFrameRateEpsilon; // 0x8
	public static readonly double k_MaxTimelineDurationInSeconds; // 0x10

	// Methods

	// RVA: 0x17E79C0 Offset: 0x17E7AC1 VA: 0x17E79C0
	private static void ValidateFrameRate(double frameRate) { }

	// RVA: 0x17E7A80 Offset: 0x17E7B81 VA: 0x17E7A80
	public static int ToFrames(double time, double frameRate) { }

	// RVA: 0x17E7CF0 Offset: 0x17E7DF1 VA: 0x17E7CF0
	public static double ToExactFrames(double time, double frameRate) { }

	// RVA: 0x17E7D70 Offset: 0x17E7E71 VA: 0x17E7D70
	public static double FromFrames(int frames, double frameRate) { }

	// RVA: 0x17E7DF0 Offset: 0x17E7EF1 VA: 0x17E7DF0
	public static double FromFrames(double frames, double frameRate) { }

	// RVA: 0x17E7E70 Offset: 0x17E7F71 VA: 0x17E7E70
	public static bool OnFrameBoundary(double time, double frameRate) { }

	// RVA: 0x17E7C30 Offset: 0x17E7D31 VA: 0x17E7C30
	public static double GetEpsilon(double time, double frameRate) { }

	// RVA: 0x17E7F80 Offset: 0x17E8081 VA: 0x17E7F80
	public static bool OnFrameBoundary(double time, double frameRate, double epsilon) { }

	// RVA: 0x17E80E0 Offset: 0x17E81E1 VA: 0x17E80E0
	public static double RoundToFrame(double time, double frameRate) { }

	// RVA: 0x17E81A0 Offset: 0x17E82A1 VA: 0x17E81A0
	public static string TimeAsFrames(double timeValue, double frameRate, string format = "F2") { }

	// RVA: 0x17E82F0 Offset: 0x17E83F1 VA: 0x17E82F0
	public static string TimeAsTimeCode(double timeValue, double frameRate, string format = "F2") { }

	// RVA: 0x17E8840 Offset: 0x17E8941 VA: 0x17E8840
	public static double ParseTimeCode(string timeCode, double frameRate, double defaultValue) { }

	// RVA: 0x17D3800 Offset: 0x17D3901 VA: 0x17D3800
	public static double GetAnimationClipLength(AnimationClip clip) { }

	// RVA: 0x17E8F10 Offset: 0x17E9011 VA: 0x17E8F10
	private static string RemoveChar(string str, Func<char, bool> charToRemoveFunc) { }

	// RVA: 0x17E9030 Offset: 0x17E9131 VA: 0x17E9030
	private static void .cctor() { }
}

