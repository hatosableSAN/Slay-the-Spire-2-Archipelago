using System.Collections.Generic;

namespace StS2AP.Utils;

/// <summary>
/// Japanese display names for items supplied by the Slay the Spire II APWorld.
/// The network protocol continues to use its canonical English names; only UI text is translated.
/// </summary>
public static class ItemNameLocalization
{
    private static readonly Dictionary<string, string> ExactNames = new()
    {
        ["Free Attack"] = "フリーアタック",
        ["Free Power"] = "フリーパワー",
        ["Free Skill"] = "フリースキル",
        ["Dexterity"] = "敏捷性",
        ["Strength"] = "筋力",
        ["Plating"] = "プレートアーマー",
        ["Friendship"] = "友情",
        ["Post-Combat Card Upgrade"] = "戦闘後のカードアップグレード",
        ["Post-Combat Card Removal"] = "戦闘後のカード削除",
        ["Additional Card Reward"] = "追加のカード報酬",
        ["Buffer"] = "バッファー",
        ["Vigor"] = "活力",
        ["Thorns"] = "トゲ",
        ["Artifact"] = "アーティファクト",
    };

    private static readonly Dictionary<string, string> CharacterNames = new()
    {
        ["Ironclad"] = "アイアンクラッド",
        ["Silent"] = "サイレント",
        ["Defect"] = "ディフェクト",
        ["Regent"] = "リージェント",
        ["Necrobinder"] = "ネクロバインダー",
    };

    private static readonly Dictionary<string, string> CharacterItemNames = new()
    {
        ["Card Reward"] = "カード報酬",
        ["Rare Card Reward"] = "レアカード報酬",
        ["Relic"] = "レリック",
        ["Progressive Ancient"] = "エンシェント利用権",
        ["One Gold"] = "1ゴールド",
        ["Five Gold"] = "5ゴールド",
        ["Combat Gold"] = "通常戦闘ゴールド",
        ["Elite Gold"] = "エリート戦ゴールド",
        ["Boss Gold"] = "ボス戦ゴールド",
        ["Progressive Rest"] = "休憩利用権",
        ["Progressive Smith"] = "鍛冶利用権",
        ["Shop Card Slot"] = "ショップのカード枠",
        ["Neutral Shop Card Slot"] = "ショップの無色カード枠",
        ["Shop Relic Slot"] = "ショップのレリック枠",
        ["Shop Potion Slot"] = "ショップのポーション枠",
        ["Progressive Shop Remove"] = "ショップ内カード削除権",
        ["Unlock"] = "キャラクター解放",
        ["Potion"] = "ポーション",
        ["Progressive Starter Card"] = "初期カード利用権",
        ["Progressive Starter Relic"] = "初期レリック利用権",
        ["Victory"] = "勝利",
        ["Beat Act 1 Boss"] = "第1層ボス撃破",
        ["Beat Act 2 Boss"] = "第2層ボス撃破",
    };

    // Translate display names only; canonical AP location names remain unchanged.
    public static string LocationToJapanese(string? locationName)
    {
        if (string.IsNullOrEmpty(locationName))
            return locationName ?? string.Empty;

        foreach (var character in CharacterNames)
        {
            var prefix = character.Key + " ";
            if (locationName.StartsWith(prefix, System.StringComparison.Ordinal))
                return TranslateLocationSuffix(character.Value, locationName[prefix.Length..], locationName);
        }

        var custom = System.Text.RegularExpressions.Regex.Match(locationName, @"^Custom Character (\d+) (.+)$");
        if (custom.Success)
            return TranslateLocationSuffix($"MODキャラ{custom.Groups[1].Value}", custom.Groups[2].Value, locationName);

        return locationName;
    }

    private static string TranslateLocationSuffix(string character, string suffix, string fallback)
    {
        if (suffix == "Press Start")
            return $"{character}：ラン開始";

        var numbered = System.Text.RegularExpressions.Regex.Match(
            suffix, @"^(Card Reward|Rare Card Reward|Relic|Shop Slot|Combat Gold|Potion Drop|Boss Gold|Ancient Act|Reached Floor) (\d+)$");
        if (numbered.Success)
        {
            var number = numbered.Groups[2].Value;
            return numbered.Groups[1].Value switch
            {
                "Card Reward" => $"{character}：カード報酬 {number}",
                "Rare Card Reward" => $"{character}：レアカード報酬 {number}",
                "Relic" => $"{character}：レリック報酬 {number}",
                "Shop Slot" => $"{character}：ショップ枠 {number}",
                "Combat Gold" => $"{character}：戦闘ゴールド {number}",
                "Potion Drop" => $"{character}：ポーション報酬 {number}",
                "Boss Gold" => $"{character}：第{number}層のボスゴールド",
                "Ancient Act" => $"{character}：第{number}層のエンシェント",
                "Reached Floor" => $"{character}：{number}階に到達",
                _ => fallback,
            };
        }

        var campfire = System.Text.RegularExpressions.Regex.Match(suffix, @"^Act (\d+) Campfire (\d+)$");
        if (campfire.Success)
            return $"{character}：第{campfire.Groups[1].Value}層の休憩所 {campfire.Groups[2].Value}";

        var boss = System.Text.RegularExpressions.Regex.Match(suffix, @"^Act (\d+) Boss$");
        return boss.Success ? $"{character}：第{boss.Groups[1].Value}層のボス" : fallback;
    }

    public static string ToJapanese(string? itemName)
    {
        if (string.IsNullOrEmpty(itemName))
            return itemName ?? string.Empty;

        if (ExactNames.TryGetValue(itemName, out var exactTranslation))
            return exactTranslation;

        foreach (var character in CharacterNames)
        {
            var prefix = character.Key + " ";
            if (!itemName.StartsWith(prefix, System.StringComparison.Ordinal))
                continue;

            var suffix = itemName[prefix.Length..];
            if (CharacterItemNames.TryGetValue(suffix, out var itemTranslation))
                return $"{character.Value}：{itemTranslation}";
        }

        const string customPrefix = "Custom Character ";
        if (itemName.StartsWith(customPrefix, System.StringComparison.Ordinal))
        {
            foreach (var item in CharacterItemNames)
            {
                var suffix = " " + item.Key;
                if (!itemName.EndsWith(suffix, System.StringComparison.Ordinal))
                    continue;

                var number = itemName[customPrefix.Length..^suffix.Length];
                return $"MODキャラ{number}：{item.Value}";
            }
        }

        return itemName;
    }
}
