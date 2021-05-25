public interface IPropertyCollector // TypeDefIndex: 4632
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PushActiveGameObject(GameObject gameObject) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void PopActiveGameObject() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AddFromClip(AnimationClip clip) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddFromClips(IEnumerable<AnimationClip> clips) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddFromName<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPropertyCollector.AddFromName<object>
	|-IPropertyCollector.AddFromName<Camera>
	|-IPropertyCollector.AddFromName<Transform>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddFromName(string name) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void AddFromClip(GameObject obj, AnimationClip clip) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void AddFromClips(GameObject obj, IEnumerable<AnimationClip> clips) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void AddFromName<T>(GameObject obj, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPropertyCollector.AddFromName<object>
	|-IPropertyCollector.AddFromName<ParticleSystem>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void AddFromName(GameObject obj, string name) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void AddFromName(Component component, string name) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void AddFromComponent(GameObject obj, Component component) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void AddObjectProperties(Object obj, AnimationClip clip) { }
}

