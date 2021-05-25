public sealed class WaitForSecondsStopFunction : CustomYieldInstruction // TypeDefIndex: 6811
{
	// Fields
	private Func<bool> stopFunc; // 0x10
	private float waitTime; // 0x18

	// Properties
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x1D029E0 Offset: 0x1D02AE1 VA: 0x1D029E0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x1D02A70 Offset: 0x1D02B71 VA: 0x1D02A70
	public void .ctor(float time, Func<bool> func) { }
}

