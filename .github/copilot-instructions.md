# GitHub Copilot Instructions for MoreSlaves Mod

## Mod Overview and Purpose
The "MoreSlaves" mod is designed for the game RimWorld, enhancing gameplay by modifying the mechanics surrounding slave trading and acquisition. The primary goal of this mod is to allow players to obtain slaves without being restricted by population caps, thereby providing more flexibility and control over their colony's development.

## Key Features and Systems
- **Slave Acquisition Without Population Cap**: The mod overrides the default behavior of slave purchasing, enabling players to acquire as many slaves as desired, regardless of the colony's current population.
  
- **Custom Mod and Settings Classes**: The mod is structured around key C# classes:
  - `MoreSlaves`: This class extends RimWorld's `Mod` class, serving as the entry point for the mod.
  - `MoreSlavesSettings`: Extends `ModSettings` to manage configurable settings for the mod.
  - `StockGenerator_Slaves_IgnorePopCap`: Extends `StockGenerator` and implements logic to ignore population caps during slave purchasing.

## Coding Patterns and Conventions
- **Class Naming**: Classes are named in PascalCase and are descriptive of their function within the mod.
- **Method Naming**: While specific methods aren't outlined in the summarized content, adhere to CamelCase for method naming, prefixed with an appropriate verb indicating the method’s action.
- **File Organization**: Separate concerns by organizing each primary class into its dedicated file, enhancing readability and maintainability.
- **Comments and Documentation**: Include XML documentation comments for classes and methods to clarify their purpose and usage within the mod’s ecosystem.

## XML Integration
- **Data Overrides and Extensions**: Utilize XML to define and override RimWorld data, such as slave trader inventories. The XML files can be used alongside the C# code to customize game data linked to the population cap logic.
- **Patch XML**: Leverage XML files for patching existing RimWorld XML definitions. Ensure new components are seamlessly integrated by specifying proper parent and child definitions in the XML configuration.

## Harmony Patching
- **Using Harmony**: If altering base game functionality without direct modification, consider using the Harmony library. This allows for dynamic patches that can modify or extend existing game methods or properties without altering the core game files.
- **Patch Safety**: Keep patches targeted and reversible to minimize conflicts and ensure compatibility with future updates or other mods.

## Suggestions for Copilot
1. **Class Extensions**: Assist in extending and modifying existing classes like `StockGenerator` by suggesting method overrides or new methods matching pattern: OverrideMethodName.
2. **XML Pattern Suggestions**: Recommend common XML patterns for integrating and extending mod data, focusing on structure necessary for patching.
3. **Patch Implementation**: Suggest example Harmony patches for modifying base game properties, mimicking commonly successful approaches.
4. **Configuration Assistance**: Offer scaffolding for `MoreSlavesSettings` to include settings persistence and loading/saving routines.
5. **Code Comments**: Encourage documentation comments for all public classes and methods.

This instruction aims to guide contributors through the development and extension of the MoreSlaves mod, maintaining a high standard of quality and compatibility within the RimWorld modding community.
