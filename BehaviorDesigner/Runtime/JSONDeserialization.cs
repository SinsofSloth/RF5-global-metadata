public class JSONDeserialization : Object // TypeDefIndex: 4674
{
	// Fields
	private static Dictionary<JSONDeserialization.TaskField, List<int>> taskIDs; // 0x0
	private static GlobalVariables globalVariables; // 0x8
	public static bool updatedSerialization; // 0x10
	private static Dictionary<int, Dictionary<string, object>> serializationCache; // 0x18

	// Methods

	// RVA: 0x1772BC0 Offset: 0x1772CC1 VA: 0x1772BC0
	private static void .cctor() { }

	// RVA: 0x17703E0 Offset: 0x17704E1 VA: 0x17703E0
	public static void Load(TaskSerializationData taskData, BehaviorSource behaviorSource) { }

	// RVA: 0x17725C0 Offset: 0x17726C1 VA: 0x17725C0
	public static void Load(string serialization, GlobalVariables globalVariables, string version) { }

	// RVA: 0x1772C70 Offset: 0x1772D71 VA: 0x1772C70
	private static void DeserializeVariables(IVariableSource variableSource, Dictionary<string, object> dict, List<Object> unityObjects) { }

	// RVA: 0x1772F60 Offset: 0x1773061 VA: 0x1772F60
	public static Task DeserializeTask(BehaviorSource behaviorSource, Dictionary<string, object> dict, ref Dictionary<int, Task> IDtoTask, List<Object> unityObjects) { }

	// RVA: 0x1774850 Offset: 0x1774951 VA: 0x1774850
	private static NodeData DeserializeNodeData(Dictionary<string, object> dict, Task task) { }

	// RVA: 0x1773D50 Offset: 0x1773E51 VA: 0x1773D50
	private static SharedVariable DeserializeSharedVariable(Dictionary<string, object> dict, IVariableSource variableSource, bool fromSource, List<Object> unityObjects) { }

	// RVA: 0x1774E20 Offset: 0x1774F21 VA: 0x1774E20
	private static void DeserializeObject(Task task, object obj, Dictionary<string, object> dict, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776860 Offset: 0x1776961 VA: 0x1776860
	private static object ValueToObject(Task task, Type type, object obj, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776660 Offset: 0x1776761 VA: 0x1776660
	private static Vector2 StringToVector2(string vector2String) { }

	// RVA: 0x1777600 Offset: 0x1777701 VA: 0x1777600
	private static Vector2Int StringToVector2Int(string vector2String) { }

	// RVA: 0x1777750 Offset: 0x1777851 VA: 0x1777750
	private static Vector3 StringToVector3(string vector3String) { }

	// RVA: 0x17778E0 Offset: 0x17779E1 VA: 0x17778E0
	private static Vector3Int StringToVector3Int(string vector3String) { }

	// RVA: 0x1777A70 Offset: 0x1777B71 VA: 0x1777A70
	private static Vector4 StringToVector4(string vector4String) { }

	// RVA: 0x1777C30 Offset: 0x1777D31 VA: 0x1777C30
	private static Quaternion StringToQuaternion(string quaternionString) { }

	// RVA: 0x1777DE0 Offset: 0x1777EE1 VA: 0x1777DE0
	private static Matrix4x4 StringToMatrix4x4(string matrixString) { }

	// RVA: 0x17781B0 Offset: 0x17782B1 VA: 0x17781B0
	private static Color StringToColor(string colorString) { }

	// RVA: 0x1778370 Offset: 0x1778471 VA: 0x1778370
	private static Rect StringToRect(string rectString) { }

	// RVA: 0x17785A0 Offset: 0x17786A1 VA: 0x17785A0
	private static LayerMask ValueToLayerMask(int value) { }

	// RVA: 0x17785D0 Offset: 0x17786D1 VA: 0x17785D0
	private static AnimationCurve ValueToAnimationCurve(Dictionary<string, object> value) { }

	// RVA: 0x17767B0 Offset: 0x17768B1 VA: 0x17767B0
	private static Object IndexToUnityObject(int index, List<Object> unityObjects) { }
}

public class JSONDeserialization : Object // TypeDefIndex: 4674
{
	// Fields
	private static Dictionary<JSONDeserialization.TaskField, List<int>> taskIDs; // 0x0
	private static GlobalVariables globalVariables; // 0x8
	public static bool updatedSerialization; // 0x10
	private static Dictionary<int, Dictionary<string, object>> serializationCache; // 0x18

	// Methods

	// RVA: 0x1772BC0 Offset: 0x1772CC1 VA: 0x1772BC0
	private static void .cctor() { }

	// RVA: 0x17703E0 Offset: 0x17704E1 VA: 0x17703E0
	public static void Load(TaskSerializationData taskData, BehaviorSource behaviorSource) { }

	// RVA: 0x17725C0 Offset: 0x17726C1 VA: 0x17725C0
	public static void Load(string serialization, GlobalVariables globalVariables, string version) { }

	// RVA: 0x1772C70 Offset: 0x1772D71 VA: 0x1772C70
	private static void DeserializeVariables(IVariableSource variableSource, Dictionary<string, object> dict, List<Object> unityObjects) { }

	// RVA: 0x1772F60 Offset: 0x1773061 VA: 0x1772F60
	public static Task DeserializeTask(BehaviorSource behaviorSource, Dictionary<string, object> dict, ref Dictionary<int, Task> IDtoTask, List<Object> unityObjects) { }

	// RVA: 0x1774850 Offset: 0x1774951 VA: 0x1774850
	private static NodeData DeserializeNodeData(Dictionary<string, object> dict, Task task) { }

	// RVA: 0x1773D50 Offset: 0x1773E51 VA: 0x1773D50
	private static SharedVariable DeserializeSharedVariable(Dictionary<string, object> dict, IVariableSource variableSource, bool fromSource, List<Object> unityObjects) { }

	// RVA: 0x1774E20 Offset: 0x1774F21 VA: 0x1774E20
	private static void DeserializeObject(Task task, object obj, Dictionary<string, object> dict, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776860 Offset: 0x1776961 VA: 0x1776860
	private static object ValueToObject(Task task, Type type, object obj, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776660 Offset: 0x1776761 VA: 0x1776660
	private static Vector2 StringToVector2(string vector2String) { }

	// RVA: 0x1777600 Offset: 0x1777701 VA: 0x1777600
	private static Vector2Int StringToVector2Int(string vector2String) { }

	// RVA: 0x1777750 Offset: 0x1777851 VA: 0x1777750
	private static Vector3 StringToVector3(string vector3String) { }

	// RVA: 0x17778E0 Offset: 0x17779E1 VA: 0x17778E0
	private static Vector3Int StringToVector3Int(string vector3String) { }

	// RVA: 0x1777A70 Offset: 0x1777B71 VA: 0x1777A70
	private static Vector4 StringToVector4(string vector4String) { }

	// RVA: 0x1777C30 Offset: 0x1777D31 VA: 0x1777C30
	private static Quaternion StringToQuaternion(string quaternionString) { }

	// RVA: 0x1777DE0 Offset: 0x1777EE1 VA: 0x1777DE0
	private static Matrix4x4 StringToMatrix4x4(string matrixString) { }

	// RVA: 0x17781B0 Offset: 0x17782B1 VA: 0x17781B0
	private static Color StringToColor(string colorString) { }

	// RVA: 0x1778370 Offset: 0x1778471 VA: 0x1778370
	private static Rect StringToRect(string rectString) { }

	// RVA: 0x17785A0 Offset: 0x17786A1 VA: 0x17785A0
	private static LayerMask ValueToLayerMask(int value) { }

	// RVA: 0x17785D0 Offset: 0x17786D1 VA: 0x17785D0
	private static AnimationCurve ValueToAnimationCurve(Dictionary<string, object> value) { }

	// RVA: 0x17767B0 Offset: 0x17768B1 VA: 0x17767B0
	private static Object IndexToUnityObject(int index, List<Object> unityObjects) { }
}

public class JSONDeserialization : Object // TypeDefIndex: 4674
{
	// Fields
	private static Dictionary<JSONDeserialization.TaskField, List<int>> taskIDs; // 0x0
	private static GlobalVariables globalVariables; // 0x8
	public static bool updatedSerialization; // 0x10
	private static Dictionary<int, Dictionary<string, object>> serializationCache; // 0x18

	// Methods

	// RVA: 0x1772BC0 Offset: 0x1772CC1 VA: 0x1772BC0
	private static void .cctor() { }

	// RVA: 0x17703E0 Offset: 0x17704E1 VA: 0x17703E0
	public static void Load(TaskSerializationData taskData, BehaviorSource behaviorSource) { }

	// RVA: 0x17725C0 Offset: 0x17726C1 VA: 0x17725C0
	public static void Load(string serialization, GlobalVariables globalVariables, string version) { }

	// RVA: 0x1772C70 Offset: 0x1772D71 VA: 0x1772C70
	private static void DeserializeVariables(IVariableSource variableSource, Dictionary<string, object> dict, List<Object> unityObjects) { }

	// RVA: 0x1772F60 Offset: 0x1773061 VA: 0x1772F60
	public static Task DeserializeTask(BehaviorSource behaviorSource, Dictionary<string, object> dict, ref Dictionary<int, Task> IDtoTask, List<Object> unityObjects) { }

	// RVA: 0x1774850 Offset: 0x1774951 VA: 0x1774850
	private static NodeData DeserializeNodeData(Dictionary<string, object> dict, Task task) { }

	// RVA: 0x1773D50 Offset: 0x1773E51 VA: 0x1773D50
	private static SharedVariable DeserializeSharedVariable(Dictionary<string, object> dict, IVariableSource variableSource, bool fromSource, List<Object> unityObjects) { }

	// RVA: 0x1774E20 Offset: 0x1774F21 VA: 0x1774E20
	private static void DeserializeObject(Task task, object obj, Dictionary<string, object> dict, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776860 Offset: 0x1776961 VA: 0x1776860
	private static object ValueToObject(Task task, Type type, object obj, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776660 Offset: 0x1776761 VA: 0x1776660
	private static Vector2 StringToVector2(string vector2String) { }

	// RVA: 0x1777600 Offset: 0x1777701 VA: 0x1777600
	private static Vector2Int StringToVector2Int(string vector2String) { }

	// RVA: 0x1777750 Offset: 0x1777851 VA: 0x1777750
	private static Vector3 StringToVector3(string vector3String) { }

	// RVA: 0x17778E0 Offset: 0x17779E1 VA: 0x17778E0
	private static Vector3Int StringToVector3Int(string vector3String) { }

	// RVA: 0x1777A70 Offset: 0x1777B71 VA: 0x1777A70
	private static Vector4 StringToVector4(string vector4String) { }

	// RVA: 0x1777C30 Offset: 0x1777D31 VA: 0x1777C30
	private static Quaternion StringToQuaternion(string quaternionString) { }

	// RVA: 0x1777DE0 Offset: 0x1777EE1 VA: 0x1777DE0
	private static Matrix4x4 StringToMatrix4x4(string matrixString) { }

	// RVA: 0x17781B0 Offset: 0x17782B1 VA: 0x17781B0
	private static Color StringToColor(string colorString) { }

	// RVA: 0x1778370 Offset: 0x1778471 VA: 0x1778370
	private static Rect StringToRect(string rectString) { }

	// RVA: 0x17785A0 Offset: 0x17786A1 VA: 0x17785A0
	private static LayerMask ValueToLayerMask(int value) { }

	// RVA: 0x17785D0 Offset: 0x17786D1 VA: 0x17785D0
	private static AnimationCurve ValueToAnimationCurve(Dictionary<string, object> value) { }

	// RVA: 0x17767B0 Offset: 0x17768B1 VA: 0x17767B0
	private static Object IndexToUnityObject(int index, List<Object> unityObjects) { }
}

public class JSONDeserialization : Object // TypeDefIndex: 4674
{
	// Fields
	private static Dictionary<JSONDeserialization.TaskField, List<int>> taskIDs; // 0x0
	private static GlobalVariables globalVariables; // 0x8
	public static bool updatedSerialization; // 0x10
	private static Dictionary<int, Dictionary<string, object>> serializationCache; // 0x18

	// Methods

	// RVA: 0x1772BC0 Offset: 0x1772CC1 VA: 0x1772BC0
	private static void .cctor() { }

	// RVA: 0x17703E0 Offset: 0x17704E1 VA: 0x17703E0
	public static void Load(TaskSerializationData taskData, BehaviorSource behaviorSource) { }

	// RVA: 0x17725C0 Offset: 0x17726C1 VA: 0x17725C0
	public static void Load(string serialization, GlobalVariables globalVariables, string version) { }

	// RVA: 0x1772C70 Offset: 0x1772D71 VA: 0x1772C70
	private static void DeserializeVariables(IVariableSource variableSource, Dictionary<string, object> dict, List<Object> unityObjects) { }

	// RVA: 0x1772F60 Offset: 0x1773061 VA: 0x1772F60
	public static Task DeserializeTask(BehaviorSource behaviorSource, Dictionary<string, object> dict, ref Dictionary<int, Task> IDtoTask, List<Object> unityObjects) { }

	// RVA: 0x1774850 Offset: 0x1774951 VA: 0x1774850
	private static NodeData DeserializeNodeData(Dictionary<string, object> dict, Task task) { }

	// RVA: 0x1773D50 Offset: 0x1773E51 VA: 0x1773D50
	private static SharedVariable DeserializeSharedVariable(Dictionary<string, object> dict, IVariableSource variableSource, bool fromSource, List<Object> unityObjects) { }

	// RVA: 0x1774E20 Offset: 0x1774F21 VA: 0x1774E20
	private static void DeserializeObject(Task task, object obj, Dictionary<string, object> dict, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776860 Offset: 0x1776961 VA: 0x1776860
	private static object ValueToObject(Task task, Type type, object obj, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776660 Offset: 0x1776761 VA: 0x1776660
	private static Vector2 StringToVector2(string vector2String) { }

	// RVA: 0x1777600 Offset: 0x1777701 VA: 0x1777600
	private static Vector2Int StringToVector2Int(string vector2String) { }

	// RVA: 0x1777750 Offset: 0x1777851 VA: 0x1777750
	private static Vector3 StringToVector3(string vector3String) { }

	// RVA: 0x17778E0 Offset: 0x17779E1 VA: 0x17778E0
	private static Vector3Int StringToVector3Int(string vector3String) { }

	// RVA: 0x1777A70 Offset: 0x1777B71 VA: 0x1777A70
	private static Vector4 StringToVector4(string vector4String) { }

	// RVA: 0x1777C30 Offset: 0x1777D31 VA: 0x1777C30
	private static Quaternion StringToQuaternion(string quaternionString) { }

	// RVA: 0x1777DE0 Offset: 0x1777EE1 VA: 0x1777DE0
	private static Matrix4x4 StringToMatrix4x4(string matrixString) { }

	// RVA: 0x17781B0 Offset: 0x17782B1 VA: 0x17781B0
	private static Color StringToColor(string colorString) { }

	// RVA: 0x1778370 Offset: 0x1778471 VA: 0x1778370
	private static Rect StringToRect(string rectString) { }

	// RVA: 0x17785A0 Offset: 0x17786A1 VA: 0x17785A0
	private static LayerMask ValueToLayerMask(int value) { }

	// RVA: 0x17785D0 Offset: 0x17786D1 VA: 0x17785D0
	private static AnimationCurve ValueToAnimationCurve(Dictionary<string, object> value) { }

	// RVA: 0x17767B0 Offset: 0x17768B1 VA: 0x17767B0
	private static Object IndexToUnityObject(int index, List<Object> unityObjects) { }
}

public class JSONDeserialization : Object // TypeDefIndex: 4674
{
	// Fields
	private static Dictionary<JSONDeserialization.TaskField, List<int>> taskIDs; // 0x0
	private static GlobalVariables globalVariables; // 0x8
	public static bool updatedSerialization; // 0x10
	private static Dictionary<int, Dictionary<string, object>> serializationCache; // 0x18

	// Methods

	// RVA: 0x1772BC0 Offset: 0x1772CC1 VA: 0x1772BC0
	private static void .cctor() { }

	// RVA: 0x17703E0 Offset: 0x17704E1 VA: 0x17703E0
	public static void Load(TaskSerializationData taskData, BehaviorSource behaviorSource) { }

	// RVA: 0x17725C0 Offset: 0x17726C1 VA: 0x17725C0
	public static void Load(string serialization, GlobalVariables globalVariables, string version) { }

	// RVA: 0x1772C70 Offset: 0x1772D71 VA: 0x1772C70
	private static void DeserializeVariables(IVariableSource variableSource, Dictionary<string, object> dict, List<Object> unityObjects) { }

	// RVA: 0x1772F60 Offset: 0x1773061 VA: 0x1772F60
	public static Task DeserializeTask(BehaviorSource behaviorSource, Dictionary<string, object> dict, ref Dictionary<int, Task> IDtoTask, List<Object> unityObjects) { }

	// RVA: 0x1774850 Offset: 0x1774951 VA: 0x1774850
	private static NodeData DeserializeNodeData(Dictionary<string, object> dict, Task task) { }

	// RVA: 0x1773D50 Offset: 0x1773E51 VA: 0x1773D50
	private static SharedVariable DeserializeSharedVariable(Dictionary<string, object> dict, IVariableSource variableSource, bool fromSource, List<Object> unityObjects) { }

	// RVA: 0x1774E20 Offset: 0x1774F21 VA: 0x1774E20
	private static void DeserializeObject(Task task, object obj, Dictionary<string, object> dict, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776860 Offset: 0x1776961 VA: 0x1776860
	private static object ValueToObject(Task task, Type type, object obj, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776660 Offset: 0x1776761 VA: 0x1776660
	private static Vector2 StringToVector2(string vector2String) { }

	// RVA: 0x1777600 Offset: 0x1777701 VA: 0x1777600
	private static Vector2Int StringToVector2Int(string vector2String) { }

	// RVA: 0x1777750 Offset: 0x1777851 VA: 0x1777750
	private static Vector3 StringToVector3(string vector3String) { }

	// RVA: 0x17778E0 Offset: 0x17779E1 VA: 0x17778E0
	private static Vector3Int StringToVector3Int(string vector3String) { }

	// RVA: 0x1777A70 Offset: 0x1777B71 VA: 0x1777A70
	private static Vector4 StringToVector4(string vector4String) { }

	// RVA: 0x1777C30 Offset: 0x1777D31 VA: 0x1777C30
	private static Quaternion StringToQuaternion(string quaternionString) { }

	// RVA: 0x1777DE0 Offset: 0x1777EE1 VA: 0x1777DE0
	private static Matrix4x4 StringToMatrix4x4(string matrixString) { }

	// RVA: 0x17781B0 Offset: 0x17782B1 VA: 0x17781B0
	private static Color StringToColor(string colorString) { }

	// RVA: 0x1778370 Offset: 0x1778471 VA: 0x1778370
	private static Rect StringToRect(string rectString) { }

	// RVA: 0x17785A0 Offset: 0x17786A1 VA: 0x17785A0
	private static LayerMask ValueToLayerMask(int value) { }

	// RVA: 0x17785D0 Offset: 0x17786D1 VA: 0x17785D0
	private static AnimationCurve ValueToAnimationCurve(Dictionary<string, object> value) { }

	// RVA: 0x17767B0 Offset: 0x17768B1 VA: 0x17767B0
	private static Object IndexToUnityObject(int index, List<Object> unityObjects) { }
}

public class JSONDeserialization : Object // TypeDefIndex: 4674
{
	// Fields
	private static Dictionary<JSONDeserialization.TaskField, List<int>> taskIDs; // 0x0
	private static GlobalVariables globalVariables; // 0x8
	public static bool updatedSerialization; // 0x10
	private static Dictionary<int, Dictionary<string, object>> serializationCache; // 0x18

	// Methods

	// RVA: 0x1772BC0 Offset: 0x1772CC1 VA: 0x1772BC0
	private static void .cctor() { }

	// RVA: 0x17703E0 Offset: 0x17704E1 VA: 0x17703E0
	public static void Load(TaskSerializationData taskData, BehaviorSource behaviorSource) { }

	// RVA: 0x17725C0 Offset: 0x17726C1 VA: 0x17725C0
	public static void Load(string serialization, GlobalVariables globalVariables, string version) { }

	// RVA: 0x1772C70 Offset: 0x1772D71 VA: 0x1772C70
	private static void DeserializeVariables(IVariableSource variableSource, Dictionary<string, object> dict, List<Object> unityObjects) { }

	// RVA: 0x1772F60 Offset: 0x1773061 VA: 0x1772F60
	public static Task DeserializeTask(BehaviorSource behaviorSource, Dictionary<string, object> dict, ref Dictionary<int, Task> IDtoTask, List<Object> unityObjects) { }

	// RVA: 0x1774850 Offset: 0x1774951 VA: 0x1774850
	private static NodeData DeserializeNodeData(Dictionary<string, object> dict, Task task) { }

	// RVA: 0x1773D50 Offset: 0x1773E51 VA: 0x1773D50
	private static SharedVariable DeserializeSharedVariable(Dictionary<string, object> dict, IVariableSource variableSource, bool fromSource, List<Object> unityObjects) { }

	// RVA: 0x1774E20 Offset: 0x1774F21 VA: 0x1774E20
	private static void DeserializeObject(Task task, object obj, Dictionary<string, object> dict, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776860 Offset: 0x1776961 VA: 0x1776860
	private static object ValueToObject(Task task, Type type, object obj, IVariableSource variableSource, List<Object> unityObjects) { }

	// RVA: 0x1776660 Offset: 0x1776761 VA: 0x1776660
	private static Vector2 StringToVector2(string vector2String) { }

	// RVA: 0x1777600 Offset: 0x1777701 VA: 0x1777600
	private static Vector2Int StringToVector2Int(string vector2String) { }

	// RVA: 0x1777750 Offset: 0x1777851 VA: 0x1777750
	private static Vector3 StringToVector3(string vector3String) { }

	// RVA: 0x17778E0 Offset: 0x17779E1 VA: 0x17778E0
	private static Vector3Int StringToVector3Int(string vector3String) { }

	// RVA: 0x1777A70 Offset: 0x1777B71 VA: 0x1777A70
	private static Vector4 StringToVector4(string vector4String) { }

	// RVA: 0x1777C30 Offset: 0x1777D31 VA: 0x1777C30
	private static Quaternion StringToQuaternion(string quaternionString) { }

	// RVA: 0x1777DE0 Offset: 0x1777EE1 VA: 0x1777DE0
	private static Matrix4x4 StringToMatrix4x4(string matrixString) { }

	// RVA: 0x17781B0 Offset: 0x17782B1 VA: 0x17781B0
	private static Color StringToColor(string colorString) { }

	// RVA: 0x1778370 Offset: 0x1778471 VA: 0x1778370
	private static Rect StringToRect(string rectString) { }

	// RVA: 0x17785A0 Offset: 0x17786A1 VA: 0x17785A0
	private static LayerMask ValueToLayerMask(int value) { }

	// RVA: 0x17785D0 Offset: 0x17786D1 VA: 0x17785D0
	private static AnimationCurve ValueToAnimationCurve(Dictionary<string, object> value) { }

	// RVA: 0x17767B0 Offset: 0x17768B1 VA: 0x17767B0
	private static Object IndexToUnityObject(int index, List<Object> unityObjects) { }
}

