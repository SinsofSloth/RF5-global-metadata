public static class EaseManager // TypeDefIndex: 5094
{
	// Fields
	private const float _PiOver2 = 1.5707964;
	private const float _TwoPi = 6.2831855;

	// Methods

	// RVA: 0x19892E0 Offset: 0x19893E1 VA: 0x19892E0
	public static float Evaluate(Tween t, float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x1989300 Offset: 0x1989401 VA: 0x1989300
	public static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x198A7D0 Offset: 0x198A8D1 VA: 0x198A7D0
	public static EaseFunction ToEaseFunction(Ease ease) { }

	// RVA: 0x198BDE0 Offset: 0x198BEE1 VA: 0x198BDE0
	internal static bool IsFlashEase(Ease ease) { }
}

