public interface MonsterHutAreaInterface // TypeDefIndex: 9929
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetFreePointIndex() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LockPointIndex(int index) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RelesePointIndex(int index) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UpdateLoveLv(int index, int loveLv) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsMostLoveLvMonster(int index) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Transform GetPointTransfrom(int index) { }
}

