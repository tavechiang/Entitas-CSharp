//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public interface IUniqueClassToGenerateEntity {

    UniqueClassToGenerateComponent uniqueClassToGenerate { get; }
    bool hasUniqueClassToGenerate { get; }

    void AddUniqueClassToGenerate(My.Namespace.UniqueClassToGenerate newValue);
    void ReplaceUniqueClassToGenerate(My.Namespace.UniqueClassToGenerate newValue);
    void RemoveUniqueClassToGenerate();
}