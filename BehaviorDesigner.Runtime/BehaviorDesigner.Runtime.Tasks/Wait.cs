[TaskDescriptionAttribute] // RVA: 0x14B710 Offset: 0x14B811 VA: 0x14B710
[TaskIconAttribute] // RVA: 0x14B710 Offset: 0x14B811 VA: 0x14B710
public class Wait : Action // TypeDefIndex: 10935
{
	// Fields
	[TooltipAttribute] // RVA: 0x1835A0 Offset: 0x1836A1 VA: 0x1835A0
	public SharedFloat waitTime; // 0x50
	[TooltipAttribute] // RVA: 0x1835E0 Offset: 0x1836E1 VA: 0x1835E0
	public SharedBool randomWait; // 0x58
	[TooltipAttribute] // RVA: 0x183620 Offset: 0x183721 VA: 0x183620
	public SharedFloat randomWaitMin; // 0x60
	[TooltipAttribute] // RVA: 0x183660 Offset: 0x183761 VA: 0x183660
	public SharedFloat randomWaitMax; // 0x68
	private float waitDuration; // 0x70
	private float startTime; // 0x74
	private float pauseTime; // 0x78

	// Methods

	// RVA: 0x22DAEF0 Offset: 0x22DAFF1 VA: 0x22DAEF0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x22DAFC0 Offset: 0x22DB0C1 VA: 0x22DAFC0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x22DB000 Offset: 0x22DB101 VA: 0x22DB000 Slot: 10
	public override void OnPause(bool paused) { }

	// RVA: 0x22DB060 Offset: 0x22DB161 VA: 0x22DB060 Slot: 16
	public override void OnReset() { }

	// RVA: 0x22DB100 Offset: 0x22DB201 VA: 0x22DB100
	public void .ctor() { }
}

