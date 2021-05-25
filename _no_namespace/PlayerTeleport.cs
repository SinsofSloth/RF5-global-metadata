public class PlayerTeleport : MonoBehaviour // TypeDefIndex: 9078
{
	// Fields
	[TooltipAttribute] // RVA: 0x176860 Offset: 0x176961 VA: 0x176860
	public UILoadingStreamer uiLoadingStreamer; // 0x18
	[TooltipAttribute] // RVA: 0x1768A0 Offset: 0x1769A1 VA: 0x1768A0
	public PlayerMover playerMover; // 0x20
	[TooltipAttribute] // RVA: 0x1768E0 Offset: 0x1769E1 VA: 0x1768E0
	public Streamer[] streamers; // 0x28
	[TooltipAttribute] // RVA: 0x176920 Offset: 0x176A21 VA: 0x176920
	public Transform player; // 0x30
	[TooltipAttribute] // RVA: 0x176960 Offset: 0x176A61 VA: 0x176960
	public WorldMover worldMover; // 0x38

	// Methods

	// RVA: 0x2205BA0 Offset: 0x2205CA1 VA: 0x2205BA0
	public void Teleport(bool showLoadingScreen) { }

	// RVA: 0x2205F30 Offset: 0x2206031 VA: 0x2205F30
	private void OnDrawGizmosSelected() { }

	// RVA: 0x2205FC0 Offset: 0x22060C1 VA: 0x2205FC0
	public void .ctor() { }
}

