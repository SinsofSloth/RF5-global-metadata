[DefaultExecutionOrder] // RVA: 0x145200 Offset: 0x145301 VA: 0x145200
public abstract class ActorController : CharacterBase // TypeDefIndex: 6302
{
	// Fields
	[HeaderAttribute] // RVA: 0x15BF90 Offset: 0x15C091 VA: 0x15BF90
	[SerializeField] // RVA: 0x15BF90 Offset: 0x15C091 VA: 0x15BF90
	private ActorID actorId; // 0x64
	[SerializeField] // RVA: 0x15BFE0 Offset: 0x15C0E1 VA: 0x15BFE0
	private RebindFrequency rebindFrequency; // 0x68
	private int LoaderId; // 0x6C

	// Properties
	public ActorID ActorID { get; }
	public virtual Actor Actor { get; }
	public virtual bool IsActive { get; }
	public bool DispOn { get; set; }

	// Methods

	// RVA: 0x1BE8D00 Offset: 0x1BE8E01 VA: 0x1BE8D00
	public ActorID get_ActorID() { }

	// RVA: 0x1BE8D10 Offset: 0x1BE8E11 VA: 0x1BE8D10 Slot: 16
	public virtual Actor get_Actor() { }

	// RVA: 0x1BE8E40 Offset: 0x1BE8F41 VA: 0x1BE8E40 Slot: 17
	public virtual bool get_IsActive() { }

	// RVA: 0x1BE8E90 Offset: 0x1BE8F91 VA: 0x1BE8E90
	public bool get_DispOn() { }

	// RVA: 0x1BE8EE0 Offset: 0x1BE8FE1 VA: 0x1BE8EE0
	public void set_DispOn(bool value) { }

	// RVA: 0x1BE8F30 Offset: 0x1BE9031 VA: 0x1BE8F30 Slot: 14
	public override void ResetAnimator() { }

	// RVA: 0x1BE9240 Offset: 0x1BE9341 VA: 0x1BE9240
	public void SwicthActorBase(ActorType actor_type) { }

	// RVA: 0x1BE92A0 Offset: 0x1BE93A1 VA: 0x1BE92A0 Slot: 18
	public virtual void OnSwitchActorBase(bool on) { }

	// RVA: 0x1BE9400 Offset: 0x1BE9501 VA: 0x1BE9400 Slot: 19
	public virtual void BeforeSwitchActorBase(bool on) { }

	// RVA: 0x1BE81D0 Offset: 0x1BE82D1 VA: 0x1BE81D0
	public void RemoveAsset() { }

	// RVA: 0x1BE9410 Offset: 0x1BE9511 VA: 0x1BE9410 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1BE94D0 Offset: 0x1BE95D1 VA: 0x1BE94D0 Slot: 20
	protected virtual void OnDestroy() { }

	// RVA: 0x1BE9550 Offset: 0x1BE9651 VA: 0x1BE9550
	public void SetActorId(ActorID actor_id) { }

	// RVA: 0x1BE7C30 Offset: 0x1BE7D31 VA: 0x1BE7C30
	public void SetActorId(ActorID actor_id, int id) { }

	// RVA: 0x1BE9560 Offset: 0x1BE9661 VA: 0x1BE9560
	protected void .ctor() { }
}

