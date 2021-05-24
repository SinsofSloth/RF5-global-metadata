public interface ICinemachineCamera // TypeDefIndex: 4852
{
	// Properties
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract int Priority { get; set; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public abstract CameraState State { get; }
	public abstract GameObject VirtualCameraGameObject { get; }
	public abstract bool IsValid { get; }
	public abstract ICinemachineCamera ParentCamera { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Description() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Priority() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Priority(int value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_Follow(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract CameraState get_State() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract GameObject get_VirtualCameraGameObject() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ICinemachineCamera get_ParentCamera() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }
}

public interface ICinemachineCamera // TypeDefIndex: 4852
{
	// Properties
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract int Priority { get; set; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public abstract CameraState State { get; }
	public abstract GameObject VirtualCameraGameObject { get; }
	public abstract bool IsValid { get; }
	public abstract ICinemachineCamera ParentCamera { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Description() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Priority() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Priority(int value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_Follow(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract CameraState get_State() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract GameObject get_VirtualCameraGameObject() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ICinemachineCamera get_ParentCamera() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }
}

public interface ICinemachineCamera // TypeDefIndex: 4852
{
	// Properties
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract int Priority { get; set; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public abstract CameraState State { get; }
	public abstract GameObject VirtualCameraGameObject { get; }
	public abstract bool IsValid { get; }
	public abstract ICinemachineCamera ParentCamera { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Description() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Priority() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Priority(int value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_Follow(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract CameraState get_State() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract GameObject get_VirtualCameraGameObject() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ICinemachineCamera get_ParentCamera() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }
}

public interface ICinemachineCamera // TypeDefIndex: 4852
{
	// Properties
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract int Priority { get; set; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public abstract CameraState State { get; }
	public abstract GameObject VirtualCameraGameObject { get; }
	public abstract bool IsValid { get; }
	public abstract ICinemachineCamera ParentCamera { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Description() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Priority() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Priority(int value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_Follow(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract CameraState get_State() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract GameObject get_VirtualCameraGameObject() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ICinemachineCamera get_ParentCamera() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }
}

public interface ICinemachineCamera // TypeDefIndex: 4852
{
	// Properties
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract int Priority { get; set; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public abstract CameraState State { get; }
	public abstract GameObject VirtualCameraGameObject { get; }
	public abstract bool IsValid { get; }
	public abstract ICinemachineCamera ParentCamera { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Description() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Priority() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Priority(int value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_Follow(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract CameraState get_State() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract GameObject get_VirtualCameraGameObject() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ICinemachineCamera get_ParentCamera() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }
}

public interface ICinemachineCamera // TypeDefIndex: 4852
{
	// Properties
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract int Priority { get; set; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public abstract CameraState State { get; }
	public abstract GameObject VirtualCameraGameObject { get; }
	public abstract bool IsValid { get; }
	public abstract ICinemachineCamera ParentCamera { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Description() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Priority() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Priority(int value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_Follow(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract CameraState get_State() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract GameObject get_VirtualCameraGameObject() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ICinemachineCamera get_ParentCamera() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }
}

