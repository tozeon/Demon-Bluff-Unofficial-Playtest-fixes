# Contributing to Demon Bluff Demo Fixes

Thanks for your interest in contributing! This mod aims to fix critical bugs in the Demon Bluff demo/playtest that affect gameplay or modding.

## How to Contribute

### Reporting Bugs
1. Check if the bug is already reported in [Issues](../../issues)
2. Create a new issue with:
   - Clear description of the bug
   - Steps to reproduce
   - Expected vs actual behavior

### Suggesting Fixes
- Open an issue describing:
  - What bug you want to fix
  - Why it's important (affects gameplay/modding)
  - Your proposed solution (if you have one)

### Submitting Code
1. **Fork** the repository
2. **Create a branch** for your fix: `git checkout -b fix/bug-name`
3. **Make your changes**:
   - Follow existing code style
   - Use HarmonyLib patches where possible
   - Add comments explaining what the fix does
   - Test thoroughly in-game
4. **Commit** with a clear message: `fix: player death not triggering at 0 health`
5. **Push** to your fork
6. **Open a Pull Request** with:
   - Description of what bug it fixes
   - How you tested it
   - Any side effects or limitations

## Guidelines

### What Fixes Are Accepted
✅ Critical gameplay bugs (game-breaking issues)
✅ Bugs that prevent mods from working properly
✅ Missing features that break expected game behavior

### What Fixes Are NOT Accepted
❌ Balance changes or gameplay tweaks
❌ Quality of life features (make a separate mod)
❌ Fixes for issues the developers are actively working on
❌ Changes that break compatibility with other mods

## Code Standards
- Use **clear variable names**
- Keep patches **minimal** and focused
- Test with and without other mods installed
- Avoid breaking changes to existing fixes

## Need Help?
- Open an issue with the `question` label
- Check existing issues and pull requests
- Be patient - this is a community project

## License
By contributing, you agree that your contributions will be licensed under the same license as this project.