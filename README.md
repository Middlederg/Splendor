# Splendor

Splendor is a known [boardgame](https://boardgamegeek.com/boardgame/148228/splendor)

The repository contains:

- Splendor.Core -> Logic of the game
- Splendor.Forms -> Windows forms client

*This is an unofficial implementation, only made for fun. You can buy the [official and real application](https://store.steampowered.com/app/376680/Splendor/)*

---

## Releases
**Steps for my future me, just not to forget how changes are deployed**

The releases folow this pattern: {MajorVersion}.{MinorVersion}.{BuildNumber} 

In order to release a **new version**:

1. Change the version in *GlobalAssemblyInfo.cs* file
2. Change version in installer project
3. Build 
4. Upload to github the released version (Splendor.msi) and tag with "v", folowed by the release number.

---
