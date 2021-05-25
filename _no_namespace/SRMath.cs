public static class SRMath // TypeDefIndex: 4289
{
	// Methods

	// RVA: 0x1A8CBA0 Offset: 0x1A8CCA1 VA: 0x1A8CBA0
	public static float Ease(float from, float to, float t, SRMath.EaseType type) { }

	// RVA: 0x1A8F870 Offset: 0x1A8F971 VA: 0x1A8F870
	public static float SpringLerp(float strength, float deltaTime) { }

	// RVA: 0x1A8F960 Offset: 0x1A8FA61 VA: 0x1A8F960
	public static float SpringLerp(float from, float to, float strength, float deltaTime) { }

	// RVA: 0x1A8FA00 Offset: 0x1A8FB01 VA: 0x1A8FA00
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime) { }

	// RVA: 0x1A8FAD0 Offset: 0x1A8FBD1 VA: 0x1A8FAD0
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime) { }

	// RVA: 0x1A8FBB0 Offset: 0x1A8FCB1 VA: 0x1A8FBB0
	public static float SmoothClamp(float value, float min, float max, float scrollMax, SRMath.EaseType easeType = 5) { }

	// RVA: 0x1A8FCF0 Offset: 0x1A8FDF1 VA: 0x1A8FCF0
	public static float LerpUnclamped(float from, float to, float t) { }

	// RVA: 0x1A8FD10 Offset: 0x1A8FE11 VA: 0x1A8FD10
	public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float t) { }

	// RVA: 0x1A8FD70 Offset: 0x1A8FE71 VA: 0x1A8FD70
	public static float FacingNormalized(Vector3 dir1, Vector3 dir2) { }

	// RVA: 0x1A8FE80 Offset: 0x1A8FF81 VA: 0x1A8FE80
	public static float WrapAngle(float angle) { }

	// RVA: 0x1A8FEC0 Offset: 0x1A8FFC1 VA: 0x1A8FEC0
	public static float NearestAngle(float to, float angle1, float angle2) { }

	// RVA: 0x1A8FF70 Offset: 0x1A90071 VA: 0x1A8FF70
	public static int Wrap(int max, int value) { }

	// RVA: 0x1A90030 Offset: 0x1A90131 VA: 0x1A90030
	public static float Wrap(float max, float value) { }

	// RVA: 0x1A90060 Offset: 0x1A90161 VA: 0x1A90060
	public static float Average(float v1, float v2) { }

	// RVA: 0x1A90070 Offset: 0x1A90171 VA: 0x1A90070
	public static float Angle(Vector2 direction) { }
}

