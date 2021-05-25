public interface IObjectLoad // TypeDefIndex: 10449
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetLoadingCount() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsUpdate() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsCompleted() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract List<GameObject> GetLoadObjectList() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerator LoadAsync(string path, bool visible) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IEnumerator LoadAsync() { }
}

