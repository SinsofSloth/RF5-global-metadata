public class HitCheckStartCommand : ToolActionCommandBase // TypeDefIndex: 6271
{
	// Properties
	public string NextActionCode1 { get; }
	public bool IsAttackHit { get; }
	public Vector3 Offset { get; }
	public float Radius { get; }

	// Methods

	// RVA: 0x2303A90 Offset: 0x2303B91 VA: 0x2303A90
	public string get_NextActionCode1() { }

	// RVA: 0x2303AB0 Offset: 0x2303BB1 VA: 0x2303AB0
	public bool get_IsAttackHit() { }

	// RVA: 0x2303AD0 Offset: 0x2303BD1 VA: 0x2303AD0
	public Vector3 get_Offset() { }

	// RVA: 0x2303AF0 Offset: 0x2303BF1 VA: 0x2303AF0
	public float get_Radius() { }

	// RVA: 0x2303B10 Offset: 0x2303C11 VA: 0x2303B10
	public void .ctor(ActionCommandDataTable actionCommandData, AS_ToolController controller) { }

	// RVA: 0x2303BA0 Offset: 0x2303CA1 VA: 0x2303BA0 Slot: 8
	public override void DoAction() { }
}

