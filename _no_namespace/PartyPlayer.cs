[Serializable]
public class PartyPlayer : PartyBase // TypeDefIndex: 6323
{
	// Properties
	public override PartyType PartyType { get; }
	public override CharacterStatusBase Status { get; }

	// Methods

	// RVA: 0x1FE0D70 Offset: 0x1FE0E71 VA: 0x1FE0D70 Slot: 4
	public override PartyType get_PartyType() { }

	// RVA: 0x1FE0D90 Offset: 0x1FE0E91 VA: 0x1FE0D90 Slot: 5
	public override CharacterStatusBase get_Status() { }

	// RVA: 0x1FE0DB0 Offset: 0x1FE0EB1 VA: 0x1FE0DB0
	public void .ctor(PartyData data) { }

	// RVA: 0x1FE0E00 Offset: 0x1FE0F01 VA: 0x1FE0E00 Slot: 6
	public override void PartyIn() { }

	// RVA: 0x1FE0E10 Offset: 0x1FE0F11 VA: 0x1FE0E10 Slot: 7
	public override void PartyOut() { }
}

