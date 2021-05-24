public static class Damper // TypeDefIndex: 4902
{
	// Fields
	private const float Epsilon = 0.0001;
	public const float kNegligibleResidual = 0.01;
	private const float kLogNegligibleResidual = -4.6051702;

	// Methods

	// RVA: 0x1A226E0 Offset: 0x1A227E1 VA: 0x1A226E0
	private static float DecayConstant(float time, float residual) { }

	// RVA: 0x1A22760 Offset: 0x1A22861 VA: 0x1A22760
	private static float DecayedRemainder(float initial, float decayConstant, float deltaTime) { }

	// RVA: 0x1A13BD0 Offset: 0x1A13CD1 VA: 0x1A13BD0
	public static float Damp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A14270 Offset: 0x1A14371 VA: 0x1A14270
	public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A13CC0 Offset: 0x1A13DC1 VA: 0x1A13CC0
	public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime) { }
}

