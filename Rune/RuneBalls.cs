public class RuneBalls : MonoBehaviour // TypeDefIndex: 10322
{
	// Fields
	private const int RF3_RUNE_BALL_FLOWER_RP = -25;
	private const int RF3_RUNE_BALL_ROCK_RP = -33;
	private const int RF3_RUNE_BALL_RP = -50;
	private const int RF3_RUNE_BALL_ROONEY = -80;
	private const int RFD_RUNE_DELETE_TIME = 3600;
	private static byte _rf_rune_cout; // 0x0
	private int availableCounter; // 0x18
	private int damage; // 0x1C
	private ParticleSystem _particleSystem; // 0x20
	private EffectID vanishId; // 0x28
	private RuneType runeType; // 0x2C
	private bool triggered; // 0x30
	private bool effectPlayed; // 0x31

	// Methods

	// RVA: 0x1D6A260 Offset: 0x1D6A361 VA: 0x1D6A260
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x1D6A8E0 Offset: 0x1D6A9E1 VA: 0x1D6A8E0
	private void rf3RuneBallDefaultInit(RuneType type_index, float x, float y, float z) { }

	// RVA: 0x1D6AA80 Offset: 0x1D6AB81 VA: 0x1D6AA80
	public void rf3RuneBallRockInit(float x, float y, float z) { }

	// RVA: 0x1D6AAB0 Offset: 0x1D6ABB1 VA: 0x1D6AAB0
	public void rf3RuneBallFlowerInit(float x, float y, float z) { }

	// RVA: 0x1D6AAE0 Offset: 0x1D6ABE1 VA: 0x1D6AAE0
	public void rf3RuneBallInit(float x, float y, float z, bool isBoost = False) { }

	// RVA: 0x1D6A490 Offset: 0x1D6A591 VA: 0x1D6A490
	public void rf3RuneBallSkillUp() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE560 Offset: 0x1AE661 VA: 0x1AE560
	// RVA: 0x1D6A9F0 Offset: 0x1D6AAF1 VA: 0x1D6A9F0
	private IEnumerator rf3RuneBallMain(RuneType _runeType = 0) { }

	// RVA: 0x1D6A800 Offset: 0x1D6A901 VA: 0x1D6A800
	private void DestroyParticle() { }

	// RVA: 0x1D6AC60 Offset: 0x1D6AD61 VA: 0x1D6AC60
	public void .ctor() { }

	// RVA: 0x1D6AC70 Offset: 0x1D6AD71 VA: 0x1D6AC70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE5D0 Offset: 0x1AE6D1 VA: 0x1AE5D0
	// RVA: 0x1D6AC80 Offset: 0x1D6AD81 VA: 0x1D6AC80
	private void <rf3RuneBallMain>b__19_0(ParticleSystem ps) { }
}

