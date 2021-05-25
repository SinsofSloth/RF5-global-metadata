public abstract class PartyBase // TypeDefIndex: 6318
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15C120 Offset: 0x15C221 VA: 0x15C120
	private PartyData <Data>k__BackingField; // 0x10

	// Properties
	public PartyData Data { get; set; }
	public int PartyNo { get; }
	public ActorID ActorId { get; set; }
	public Actor Actor { get; }
	public bool IsActive { get; }
	public virtual PartyType PartyType { get; }
	public virtual CharacterStatusBase Status { get; }
	public ActorController ActorController { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19AC10 Offset: 0x19AD11 VA: 0x19AC10
	// RVA: 0x1FDF3A0 Offset: 0x1FDF4A1 VA: 0x1FDF3A0
	public PartyData get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AC20 Offset: 0x19AD21 VA: 0x19AC20
	// RVA: 0x1FDF3B0 Offset: 0x1FDF4B1 VA: 0x1FDF3B0
	private void set_Data(PartyData value) { }

	// RVA: 0x1FDF3C0 Offset: 0x1FDF4C1 VA: 0x1FDF3C0
	public int get_PartyNo() { }

	// RVA: 0x1FDF3E0 Offset: 0x1FDF4E1 VA: 0x1FDF3E0
	public ActorID get_ActorId() { }

	// RVA: 0x1FDF400 Offset: 0x1FDF501 VA: 0x1FDF400
	public void set_ActorId(ActorID value) { }

	// RVA: 0x1FDF420 Offset: 0x1FDF521 VA: 0x1FDF420
	public Actor get_Actor() { }

	// RVA: 0x1FDF440 Offset: 0x1FDF541 VA: 0x1FDF440
	public bool get_IsActive() { }

	// RVA: 0x1FDF520 Offset: 0x1FDF621 VA: 0x1FDF520 Slot: 4
	public virtual PartyType get_PartyType() { }

	// RVA: 0x1FDF530 Offset: 0x1FDF631 VA: 0x1FDF530 Slot: 5
	public virtual CharacterStatusBase get_Status() { }

	// RVA: 0x1FDF540 Offset: 0x1FDF641 VA: 0x1FDF540
	public ActorController get_ActorController() { }

	// RVA: 0x1FDF570 Offset: 0x1FDF671 VA: 0x1FDF570
	public void .ctor(PartyData partyData) { }

	// RVA: 0x1FDF5B0 Offset: 0x1FDF6B1 VA: 0x1FDF5B0 Slot: 6
	public virtual void PartyIn() { }

	// RVA: 0x1FDF5C0 Offset: 0x1FDF6C1 VA: 0x1FDF5C0 Slot: 7
	public virtual void PartyOut() { }

	// RVA: 0x1FDF5D0 Offset: 0x1FDF6D1 VA: 0x1FDF5D0 Slot: 8
	protected virtual void PartyEventUpdate(int hour) { }
}

