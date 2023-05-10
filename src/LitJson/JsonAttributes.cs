using System;

namespace LitJson
{
    /// <summary>
    /// Apply data on one constructor for an class or struct when deserialization was occured.<br />
    /// Careful that one class should never contains more than one attribute or lower attribute will being ignored.
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Constructor)]
    public class JsonConstructorAttribute : Attribute {}

    /// <summary>
    /// Apply on private field or property to indicate that field or property should not being serialized.
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Field | AttributeTargets.Property)]
    public class JsonIgnoreAttribute : Attribute {}
    
    
    /// <summary>
    /// Apply on private field or property to indicate that field or property should being serialized.
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Field | AttributeTargets.Property)]
    public class JsonSerializableAttribute : Attribute {}

}