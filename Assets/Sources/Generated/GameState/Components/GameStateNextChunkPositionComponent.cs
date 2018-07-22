//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity nextChunkPositionEntity { get { return GetGroup(GameStateMatcher.NextChunkPosition).GetSingleEntity(); } }
    public NextChunkPositionComponent nextChunkPosition { get { return nextChunkPositionEntity.nextChunkPosition; } }
    public bool hasNextChunkPosition { get { return nextChunkPositionEntity != null; } }

    public GameStateEntity SetNextChunkPosition(float newValue) {
        if (hasNextChunkPosition) {
            throw new Entitas.EntitasException("Could not set NextChunkPosition!\n" + this + " already has an entity with NextChunkPositionComponent!",
                "You should check if the context already has a nextChunkPositionEntity before setting it or use context.ReplaceNextChunkPosition().");
        }
        var entity = CreateEntity();
        entity.AddNextChunkPosition(newValue);
        return entity;
    }

    public void ReplaceNextChunkPosition(float newValue) {
        var entity = nextChunkPositionEntity;
        if (entity == null) {
            entity = SetNextChunkPosition(newValue);
        } else {
            entity.ReplaceNextChunkPosition(newValue);
        }
    }

    public void RemoveNextChunkPosition() {
        nextChunkPositionEntity.Destroy();
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

    public NextChunkPositionComponent nextChunkPosition { get { return (NextChunkPositionComponent)GetComponent(GameStateComponentsLookup.NextChunkPosition); } }
    public bool hasNextChunkPosition { get { return HasComponent(GameStateComponentsLookup.NextChunkPosition); } }

    public void AddNextChunkPosition(float newValue) {
        var index = GameStateComponentsLookup.NextChunkPosition;
        var component = CreateComponent<NextChunkPositionComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceNextChunkPosition(float newValue) {
        var index = GameStateComponentsLookup.NextChunkPosition;
        var component = CreateComponent<NextChunkPositionComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveNextChunkPosition() {
        RemoveComponent(GameStateComponentsLookup.NextChunkPosition);
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

    static Entitas.IMatcher<GameStateEntity> _matcherNextChunkPosition;

    public static Entitas.IMatcher<GameStateEntity> NextChunkPosition {
        get {
            if (_matcherNextChunkPosition == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.NextChunkPosition);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherNextChunkPosition = matcher;
            }

            return _matcherNextChunkPosition;
        }
    }
}