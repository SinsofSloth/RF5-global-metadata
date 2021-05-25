[Serializable]
public class PartyHuman : PartyBase // TypeDefIndex: 6321
{
	// Properties
	public override PartyType PartyType { get; }
	public override CharacterStatusBase Status { get; }

	// Methods

	// RVA: 0x1FE00E0 Offset: 0x1FE01E1 VA: 0x1FE00E0 Slot: 4
	public override PartyType get_PartyType() { }

	// RVA: 0x1FE0100 Offset: 0x1FE0201 VA: 0x1FE0100 Slot: 5
	public override CharacterStatusBase get_Status() { }

	// RVA: 0x1FE0120 Offset: 0x1FE0221 VA: 0x1FE0120
	public void .ctor(PartyData data) { }

	// RVA: 0x1FE0180 Offset: 0x1FE0281 VA: 0x1FE0180 Slot: 6
	public override void PartyIn() { }

	// RVA: 0x1FE0320 Offset: 0x1FE0421 VA: 0x1FE0320 Slot: 7
	public override void PartyOut() { }

	// RVA: 0x1FE04D0 Offset: 0x1FE05D1 VA: 0x1FE04D0 Slot: 8
	protected override void PartyEventUpdate(int hour) { }

	// RVA: 0x1FE0960 Offset: 0x1FE0A61 VA: 0x1FE0960
	private void OnDeadEvent() { }

	// RVA: 0x1FE0500 Offset: 0x1FE0601 VA: 0x1FE0500
	private void AddLovePoint(int diff) { }

	// RVA: 0x1FE06C0 Offset: 0x1FE07C1 VA: 0x1FE06C0
	private void LeavePartnerByTime(int diff) { }
}

