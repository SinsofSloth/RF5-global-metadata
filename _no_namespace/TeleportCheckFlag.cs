public class TeleportCheckFlag : MonoBehaviour // TypeDefIndex: 7513
{
	// Fields
	[SerializeField] // RVA: 0x166CD0 Offset: 0x166DD1 VA: 0x166CD0
	protected ActorID CheckActorID; // 0x18
	[SerializeField] // RVA: 0x166CE0 Offset: 0x166DE1 VA: 0x166CE0
	protected bool CheckFlagState; // 0x1C
	[SerializeField] // RVA: 0x166CF0 Offset: 0x166DF1 VA: 0x166CF0
	protected GameFlagData GameFlagData; // 0x20
	[SerializeField] // RVA: 0x166D00 Offset: 0x166E01 VA: 0x166D00
	protected string EventScriptString; // 0x28

	// Methods

	// RVA: 0x20A5A90 Offset: 0x20A5B91 VA: 0x20A5A90
	private void Awake() { }

	// RVA: 0x20A5B40 Offset: 0x20A5C41 VA: 0x20A5B40
	private bool CanTeleport() { }

	// RVA: 0x20A5C40 Offset: 0x20A5D41 VA: 0x20A5C40
	private bool CheckPartyActor(ActorID checkActorID) { }

	// RVA: 0x20A5CE0 Offset: 0x20A5DE1 VA: 0x20A5CE0
	public void .ctor() { }
}

