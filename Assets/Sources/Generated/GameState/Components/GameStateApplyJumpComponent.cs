//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity applyJumpEntity { get { return GetGroup(GameStateMatcher.ApplyJump).GetSingleEntity(); } }

    public bool isApplyJump {
        get { return applyJumpEntity != null; }
        set {
            var entity = applyJumpEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isApplyJump = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    static readonly ApplyJumpComponent applyJumpComponent = new ApplyJumpComponent();

    public bool isApplyJump {
        get { return HasComponent(GameStateComponentsLookup.ApplyJump); }
        set {
            if (value != isApplyJump) {
                var index = GameStateComponentsLookup.ApplyJump;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : applyJumpComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherApplyJump;

    public static Entitas.IMatcher<GameStateEntity> ApplyJump {
        get {
            if (_matcherApplyJump == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.ApplyJump);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherApplyJump = matcher;
            }

            return _matcherApplyJump;
        }
    }
}