public class BaseSpriteItemData // TypeDefIndex: 9692
{
	// Fields
	public SpriteSheetData spriteSheetData; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17EB70 Offset: 0x17EC71 VA: 0x17EB70
	private Matrix4x4 <modelMatrix>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17EB80 Offset: 0x17EC81 VA: 0x17EB80
	private BaseSpriteItemData.SpriteState <state>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x17EB90 Offset: 0x17EC91 VA: 0x17EB90
	private Vector3 <spritePosition>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x17EBA0 Offset: 0x17ECA1 VA: 0x17EBA0
	private float <startTime>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x17EBB0 Offset: 0x17ECB1 VA: 0x17EBB0
	private float <endTime>k__BackingField; // 0x6C
	public float delay; // 0x70

	// Properties
	public Matrix4x4 modelMatrix { get; set; }
	public BaseSpriteItemData.SpriteState state { get; set; }
	public Vector3 spritePosition { get; set; }
	public float startTime { get; set; }
	public float endTime { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AC690 Offset: 0x1AC791 VA: 0x1AC690
	// RVA: 0x22B0850 Offset: 0x22B0951 VA: 0x22B0850
	public Matrix4x4 get_modelMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC6A0 Offset: 0x1AC7A1 VA: 0x1AC6A0
	// RVA: 0x22B0880 Offset: 0x22B0981 VA: 0x22B0880
	protected void set_modelMatrix(Matrix4x4 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC6B0 Offset: 0x1AC7B1 VA: 0x1AC6B0
	// RVA: 0x22B08A0 Offset: 0x22B09A1 VA: 0x22B08A0
	public BaseSpriteItemData.SpriteState get_state() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC6C0 Offset: 0x1AC7C1 VA: 0x1AC6C0
	// RVA: 0x22B08B0 Offset: 0x22B09B1 VA: 0x22B08B0
	protected void set_state(BaseSpriteItemData.SpriteState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC6D0 Offset: 0x1AC7D1 VA: 0x1AC6D0
	// RVA: 0x22B08C0 Offset: 0x22B09C1 VA: 0x22B08C0
	public Vector3 get_spritePosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC6E0 Offset: 0x1AC7E1 VA: 0x1AC6E0
	// RVA: 0x22B08D0 Offset: 0x22B09D1 VA: 0x22B08D0
	public void set_spritePosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC6F0 Offset: 0x1AC7F1 VA: 0x1AC6F0
	// RVA: 0x22B08E0 Offset: 0x22B09E1 VA: 0x22B08E0
	public float get_startTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC700 Offset: 0x1AC801 VA: 0x1AC700
	// RVA: 0x22B08F0 Offset: 0x22B09F1 VA: 0x22B08F0
	protected void set_startTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC710 Offset: 0x1AC811 VA: 0x1AC710
	// RVA: 0x22B0900 Offset: 0x22B0A01 VA: 0x22B0900
	public float get_endTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC720 Offset: 0x1AC821 VA: 0x1AC720
	// RVA: 0x22B0910 Offset: 0x22B0A11 VA: 0x22B0910
	protected void set_endTime(float value) { }

	// RVA: 0x22B0920 Offset: 0x22B0A21 VA: 0x22B0920
	public void .ctor() { }

	// RVA: 0x22B0160 Offset: 0x22B0261 VA: 0x22B0160
	public void SetTRSMatrix(Vector3 worldPosition, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x22B0280 Offset: 0x22B0381 VA: 0x22B0280
	public void Start() { }

	// RVA: 0x22B02F0 Offset: 0x22B03F1 VA: 0x22B02F0
	public void Continue() { }

	// RVA: 0x22AF650 Offset: 0x22AF751 VA: 0x22AF650
	public void Reset() { }

	// RVA: 0x22B0950 Offset: 0x22B0A51 VA: 0x22B0950
	public static float CalculateStartTimeWithDelay(float delay) { }

	// RVA: 0x22B0980 Offset: 0x22B0A81 VA: 0x22B0980
	public static float CalculateEndTime(float startTime, int itemCount, int animationSpeed) { }
}

