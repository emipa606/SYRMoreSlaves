# GitHub Copilot Instructions for `[SYR] More Slaves (Continued)`

## Mod Overview and Purpose

The `[SYR] More Slaves (Continued)` mod is an updated version of the original "More Slaves" mod by Ziehn, maintained by Syrchalis. This mod augments the slave trade dynamics within RimWorld by increasing the count of slaves offered by traders. It alters the base game mechanics by adjusting the number of slaves available with slave-carrying traders and bases. This change enhances gameplay by offering a wider selection of slaves for players, enriching the strategy and planning aspects of the game.

## Key Features and Systems

- **Increased Slave Count**: Default slave offers from traders are increased from 0-2 to 2-4, observing population limits in the game.
- **Exceeding Population Limits**: Allows the possibility of offering 3-5 slaves beyond population limits, configurable through mod settings.
- **Compatibility**: The mod is fully compatible with existing save games and does not present any known incompatibilities with other mods.
- **Ease of Troubleshooting**: Instructions are provided for obtaining support through log uploads and Discord channels, enhancing user experience and troubleshooting efficiency.

## Coding Patterns and Conventions

- **C# Conventions**: 
  - Follow standard naming conventions for class and method names. 
  - Use PascalCasing for classes and methods, e.g., `MoreSlaves`, `GenerateThings`.
  - Consistent use of brackets and indentation for clarity and maintainability.
  - Apply XML comments for public members to improve code readability and maintainability.

- **XML Usage**:
  - Utilize well-structured XML files for patching and metadata.
  - Ensure XML files adhere to the proper schema to avoid conflicts or errors in parsing.

## XML Integration

- **Patch Files**: 
  - The `MoreSlaves_Patches.xml` is responsible for implementing specific changes to the game logic using defined patches.
  - Properly structured XML ensures that patches are applied without causing errors or conflicts.
  - Use Xpath functions wisely to target specific game elements and modify them as required.

## Harmony Patching

- **Harmony Patching**:
  - Utilize Harmony for injecting new mechanics into the existing game codebase without directly altering the original files.
  - Code for patches should employ concise and clear logic to minimize performance impacts.
  - Ensure all Harmony patches are well-documented, detailing their purpose and function within the mod.

## Suggestions for Copilot

- **Code Generation**:
  - Encourage Copilot to suggest function signatures and documentation for new C# methods by analyzing patterns from existing code.
  - Instruct Copilot to auto-complete XML tags and suggest attribute values based on existing schema.

- **Debugging and Error Handling**:
  - Prompt Copilot to suggest try-catch blocks where exceptions might occur, especially in network or file operations.
  - Foster better error logging by suggesting structured logging statements with detailed outputs.

By following these guidelines and leveraging Copilot's assistance effectively, contributors can streamline their development process, maintain coding standards, and ensure high-quality mod enhancements.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

