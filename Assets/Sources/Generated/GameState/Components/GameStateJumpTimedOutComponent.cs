//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity jumpTimedOutEntity { get { return GetGroup(GameStateMatcher.JumpTimedOut).GetSingleEntity(); } }

    public bool isJumpTimedOut {
        get { return jumpTimedOutEntity != null; }
        set {
            var entity = jumpTimedOutEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isJumpTimedOut = true;
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

    static readonly JumpTimedOutComponent jumpTimedOutComponent = new JumpTimedOutComponent();

    public bool isJumpTimedOut {
        get { return HasComponent(GameStateComponentsLookup.JumpTimedOut); }
        set {
            if (value != isJumpTimedOut) {
                var index = GameStateComponentsLookup.JumpTimedOut;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : jumpTimedOutComponent;

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

    static Entitas.IMatcher<GameStateEntity> _matcherJumpTimedOut;

    public static Entitas.IMatcher<GameStateEntity> JumpTimedOut {
        get {
            if (_matcherJumpTimedOut == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.JumpTimedOut);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherJumpTimedOut = matcher;
            }

            return _matcherJumpTimedOut;
        }
    }
}
