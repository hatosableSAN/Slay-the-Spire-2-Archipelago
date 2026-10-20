# 日本語翻訳レビュー一覧

対象はこのリポジトリ内の日本語表示。ゲーム本体の翻訳、生成済みビルド、Webサイト全体は対象外。翻訳の実装は変更していない。

「修正案」はレビュー用の候補で、確定訳ではない。「—」は確認・記入待ち。公式用語との照合が必要なものは注記した。改行は `<br>` で表示する。変数 `{...}` と装飾タグ `[...]` は修正時も保持する。

## 先に決めたい用語・表現

| 対象 | 現在の表記 | 検討事項 |
| --- | --- | --- |
| Progressive | プログレッシブ | 「段階解放」など意味が伝わる訳にするか。JSONとアイテム名を揃える。 |
| Ancient / Ancients | 古代レリック | 存在とレリックの呼び分け、ゲーム本体の正式用語を確認する。 |
| Check / Sanity | チェック／サニティ | AP用語を残すか、説明を補うかを決める。 |
| Act | Act | ゲーム本体の表記に合わせる。 |
| Removal | 削除 | 「除去」などゲーム本体の表記に合わせる。 |
| 報酬操作 | 受け取る／交換／戦利品 | 実際の操作に応じて統一する。 |
| 文体 | 常体／敬体が混在 | 説明文・確認ダイアログ・エラーの文体をそれぞれ統一する。 |

## JSONの英日対照


### cards.json

修正元：`client/StS2AP/godot/Archipelago/localization/jpn/cards.json`

| ID | キー | 英語原文 | 現在の日本語 | 修正案 | 確認事項 |
| --- | --- | --- | --- | --- | --- |
| J001 | DEATH_LINK_CURSE.title | Death Fragment | 死の断片 | — | — |
| J002 | DEATH_LINK_CURSE.description | Made when {death_message}. | {death_message}ことによって生まれた。 | {death_message}によって生まれた。 | 差し込まれる死亡メッセージとの文法接続を確認する。 |
| J003 | AP_ITEM_CARD_PROGRESSION.title | Catalyst | 触媒 | — | — |
| J004 | AP_ITEM_CARD_PROGRESSION.description | ({classification}) {item_name} for {player_name}. | （{classification}）{player_name}への{item_name}。 | — | — |
| J005 | AP_ITEM_CARD_USEFUL.title | Utility | 有用品 | 便利な道具 | 「有用品」は不自然。カード名としての語感を確認する。 |
| J006 | AP_ITEM_CARD_USEFUL.description | ({classification}) {item_name} for {player_name}. | （{classification}）{player_name}への{item_name}。 | — | — |
| J007 | AP_ITEM_CARD_FILLER.title | Trinket | 小物 | — | — |
| J008 | AP_ITEM_CARD_FILLER.description | ({classification}) {item_name} for {player_name}. | （{classification}）{player_name}への{item_name}。 | — | — |
| J009 | AP_ITEM_CARD_TRAP.title | Normality | 正常性 | 平常心（仮） | 「正常性」は直訳調。ゲーム本体の同名カードの正式訳を確認して合わせる。 |
| J010 | AP_ITEM_CARD_TRAP.description | ({classification}) Inflict {item_name} for {player_name}. | （{classification}）{player_name}に{item_name}を与える。 | — | — |

### characters.json

修正元：`client/StS2AP/godot/Archipelago/localization/jpn/characters.json`

| ID | キー | 英語原文 | 現在の日本語 | 修正案 | 確認事項 |
| --- | --- | --- | --- | --- | --- |
| J011 | IRONCLAD.unlockText | Hidden in the [rainbow]Multiworld[/rainbow] | [rainbow]マルチワールド[/rainbow]のどこかに隠されている | — | — |
| J012 | SILENT.unlockText | Hidden in the [rainbow]Multiworld[/rainbow] | [rainbow]マルチワールド[/rainbow]のどこかに隠されている | — | — |
| J013 | DEFECT.unlockText | Hidden in the [rainbow]Multiworld[/rainbow] | [rainbow]マルチワールド[/rainbow]のどこかに隠されている | — | — |
| J014 | NECROBINDER.unlockText | Hidden in the [rainbow]Multiworld[/rainbow] | [rainbow]マルチワールド[/rainbow]のどこかに隠されている | — | — |
| J015 | REGENT.unlockText | Hidden in the [rainbow]Multiworld[/rainbow] | [rainbow]マルチワールド[/rainbow]のどこかに隠されている | — | — |
| J016 | APCHARACTER.unlockText | Hidden in the [rainbow]Multiworld[/rainbow] | [rainbow]マルチワールド[/rainbow]のどこかに隠されている | — | — |

### events.json

修正元：`client/StS2AP/godot/Archipelago/localization/jpn/events.json`

| ID | キー | 英語原文 | 現在の日本語 | 修正案 | 確認事項 |
| --- | --- | --- | --- | --- | --- |
| J017 | AP_PROCEED.description |  |  | — | 空文字。 |
| J018 | AP_PROCEED.title | Time for some Burger King. | バーガーキングの時間だ。 | — | — |

### gameplay_ui.json

修正元：`client/StS2AP/godot/Archipelago/localization/jpn/gameplay_ui.json`

| ID | キー | 英語原文 | 現在の日本語 | 修正案 | 確認事項 |
| --- | --- | --- | --- | --- | --- |
| J019 | AP_LOAD_RECOVERY.header | Load Recovery Save | 復旧セーブを読み込む | — | — |
| J020 | AP_LOAD_RECOVERY.body | You had a run in-progress before losing connection.<br><br> Would you like to continue it? (If not, the local recovery file will be deleted, and you'll only have access to saves available on the server') | 接続が切れる前に進行中だったランがある。<br><br>このランを続行する？（続行しない場合、ローカルの復旧ファイルは削除され、サーバー上のセーブだけが利用可能になる） | — | — |
| J021 | AP_LOST_CONNECTION.header | Lost Connection | 接続切断 | — | — |
| J022 | AP_LOST_CONNECTION.body | Connection to the Archipelago Server has been lost. You will be returned to the Main Menu now.<br><br> Would you like to make a recovery save file? | Archipelagoサーバーとの接続が切れたため、メインメニューに戻る。<br><br>復旧用のセーブファイルを作成する？ | — | — |

### main_menu_ui.json

修正元：`client/StS2AP/godot/Archipelago/localization/jpn/main_menu_ui.json`

| ID | キー | 英語原文 | 現在の日本語 | 修正案 | 確認事項 |
| --- | --- | --- | --- | --- | --- |
| J023 | CONTINUE_RUN.header | Continue Run? | ランを続行する？ | — | — |
| J024 | CONTINUE_RUN.body | Would you like to resume your last AP save for this character? (Yes, AP keeps the save even if you die.) | このキャラクターで最後に使用したAPセーブから再開する？（APでは死亡してもセーブが保持される） | — | — |
| J025 | VERSION_MISMATCH.header | Version Mismatch | バージョン不一致 | — | — |
| J026 | VERSION_MISMATCH.body | The version of the apworld does not match the version of the client. If you connect to the server anyway, you may encounter unexpected behavior.<br><br>Server Version: {server}<br><br>Client Version: {client}<br><br>Connect anyways? | apworldとクライアントのバージョンが一致していない。このままサーバーへ接続すると、予期しない問題が発生する可能性がある。<br><br>サーバーバージョン：{server}<br><br>クライアントバージョン：{client}<br><br>このまま接続する？ | — | — |
| J027 | INSTALL_APWORLD.header | Install/Update APWorld? | APWorldをインストール／更新する？ | — | — |
| J028 | INSTALL_APWORLD.body | The APWorld is [i]only necessary[/i] if you're [b]hosting the Archipelago yourself[/b], and to install it you must have the [b]Archipelago Launcher (v0.6.7 or later) installed[/b] for this to work.<br><br>This will install in the background and take a few moments, then please restart your launcher. Proceed? | APWorldが必要なのは、[b]自分でArchipelagoをホストする場合[/b][i]のみ[/i]。インストールには[b]Archipelago Launcher v0.6.7以降[/b]が必要になる。<br><br>バックグラウンドでのインストールには少し時間がかかる。完了後にランチャーを再起動する必要がある。続行する？ | — | — |

### potions.json

修正元：`client/StS2AP/godot/Archipelago/localization/jpn/potions.json`

| ID | キー | 英語原文 | 現在の日本語 | 修正案 | 確認事項 |
| --- | --- | --- | --- | --- | --- |
| J029 | shop_potion_title | Archipelago Item | Archipelagoアイテム | — | — |
| J030 | shop_potion_description | ({classification}) {item_name} for {player_name}. | （{classification}）{player_name}への{item_name}。 | — | — |
| J031 | AP_ITEM_POTION_MODEL.title | Archipelago Check | Archipelagoチェック | — | — |
| J032 | AP_ITEM_POTION_MODEL.description | It is a check whatcha expecting | チェックだ。それ以上何を期待していた？ | チェックだよ。他に何か期待してた？ | 原文のくだけた調子に対して現訳は強い口調。 |

### relics.json

修正元：`client/StS2AP/godot/Archipelago/localization/jpn/relics.json`

| ID | キー | 英語原文 | 現在の日本語 | 修正案 | 確認事項 |
| --- | --- | --- | --- | --- | --- |
| J033 | shop_relic_title | {item_name} ({classification}) | {item_name}（{classification}） | — | — |
| J034 | shop_relic_description | ({classification}) {item_name} for {player_name}. | （{classification}）{player_name}への{item_name}。 | — | — |
| J035 | AP_ITEM_RELIC_MODEL.title | Archipelago Check | Archipelagoチェック | — | — |
| J036 | AP_ITEM_RELIC_MODEL.description | It is a check whatcha expecting | チェックだ。それ以上何を期待していた？ | チェックだよ。他に何か期待してた？ | ポーションと同じ文言に揃える。 |
| J037 | ARCHIPELAGO_RELIC_RELIC_COUPONS.title | Relic Coupons | レリック引換券 | — | — |
| J038 | ARCHIPELAGO_RELIC_RELIC_COUPONS.description | Earn Relic Coupons from Elites and Treasure Chests. Each coupon is paired with an Archipelago Relic item, granting its relic through naturally or via the Archipelago rewards menu. | エリートと宝箱からレリック引換券を獲得する。各引換券はArchipelagoのレリックアイテムと対になっており、通常の進行またはArchipelago報酬メニューから対応するレリックを入手できる。 | — | — |
| J039 | ARCHIPELAGO_RELIC_RELIC_COUPONS.flavor | A promise that somewhere in the multiworld, a relic is waiting for you. | マルチワールドのどこかで、レリックが待っているという約束。 | — | — |

### rest_site_ui.json

修正元：`client/StS2AP/godot/Archipelago/localization/jpn/rest_site_ui.json`

| ID | キー | 英語原文 | 現在の日本語 | 修正案 | 確認事項 |
| --- | --- | --- | --- | --- | --- |
| J040 | OPTION_PROGRESSION.name | Seems important! | 重要そうだ！ | — | — |
| J041 | OPTION_APIcon.name | Seems important! | 重要そうだ！ | — | — |
| J042 | OPTION_USEFUL.name | Might be useful? | 役に立つかも？ | — | — |
| J043 | OPTION_FILLER.name | Who left this here? | 誰がこんな所に置いた？ | — | — |
| J044 | OPTION_TRAP.name | Seems important? | 重要そう？ | — | — |
| J045 | OPTION_NOTHING.name | Do Nothing | 何もしない | — | — |
| J046 | OPTION_NOTHING.descriptionDisabled | [red]You have not received enough Progressive Rests/Smiths[/red] | [red]プログレッシブ休憩／鍛冶を十分に受け取っていない[/red] | — | — |
| J047 | OPTION_HEAL.descriptionDisabled | [red]You have not received enough Progressive Rests[/red] | [red]プログレッシブ休憩を十分に受け取っていない[/red] | — | — |
| J048 | OPTION_SMITH.descriptionDisabled | [red]You have not received enough Progressive Smiths[/red] | [red]プログレッシブ鍛冶を十分に受け取っていない[/red] | — | — |
| J049 | OPTION_CHECK.description | {description} | {description} | — | — |

### static_hover_tips.json

修正元：`client/StS2AP/godot/Archipelago/localization/jpn/static_hover_tips.json`

| ID | キー | 英語原文 | 現在の日本語 | 修正案 | 確認事項 |
| --- | --- | --- | --- | --- | --- |
| J050 | ARCHIPELAGO_TOPBARBUTTON_REWARDS.title | Archipelago Rewards | Archipelago報酬 | — | — |
| J051 | ARCHIPELAGO_TOPBARBUTTON_REWARDS.description | Claim the rewards that have been sent to you from the Multiworld! The items refresh on each new run. | マルチワールドから送られた報酬を受け取る。アイテムは新しいランを開始するたびに更新される。 | — | — |
| J052 | AP_REWARD_CARD_CHECKS.title | Card Checks | カードチェック | — | — |
| J053 | AP_REWARD_CARD_CHECKS.description | The number of AP Checks found that replaced Card Rewards | カード報酬と置き換わって発見されたAPチェックの数 | — | — |
| J054 | AP_REWARD_RARE_CARD_CHECKS.title | Rare Card Checks | レアカードチェック | — | — |
| J055 | AP_REWARD_RARE_CARD_CHECKS.description | The number of AP Checks found that replaced Rare Card Rewards | レアカード報酬と置き換わって発見されたAPチェックの数 | — | — |
| J056 | AP_REWARD_RELIC_CHECKS.title | Relic Checks | レリックチェック | — | — |
| J057 | AP_REWARD_RELIC_CHECKS.description | The number of AP Checks found that replaced Relic Rewards | レリック報酬と置き換わって発見されたAPチェックの数 | — | — |
| J058 | AP_REWARD_ANCIENT_CHECKS.title | Ancient Checks | 古代レリックチェック | 古代の存在チェック（仮） | Ancientが存在そのものか、そのレリックかを確認して用語を揃える。 |
| J059 | AP_REWARD_ANCIENT_CHECKS.description | The number of AP Checks found at Ancient Relics | 古代レリックで発見されたAPチェックの数 | — | — |
| J060 | AP_REWARD_FLOORSANITY_CHECKS.title | Floorsanity Checks | フロアサニティチェック | — | — |
| J061 | AP_REWARD_FLOORSANITY_CHECKS.description | The number of AP Checks sent for each floor reached | 各階への到達時に送信されたAPチェックの数 | — | — |
| J062 | AP_REWARD_POTIONSANITY_CHECKS.title | Potionsanity Checks | ポーションサニティチェック | — | — |
| J063 | AP_REWARD_POTIONSANITY_CHECKS.description | The number of AP Checks found that replaced Potion Rewards | ポーション報酬と置き換わって発見されたAPチェックの数 | — | — |
| J064 | AP_REWARD_GOLDSANITY_CHECKS.title | Goldsanity Checks | ゴールドサニティチェック | — | — |
| J065 | AP_REWARD_GOLDSANITY_CHECKS.description | The number of AP Checks found that replaced Gold Rewards | ゴールド報酬と置き換わって発見されたAPチェックの数 | — | — |
| J066 | AP_REWARD_CAMPFIRESANITY_CHECKS.title | Campfiresanity Checks | 焚き火サニティチェック | — | — |
| J067 | AP_REWARD_CAMPFIRESANITY_CHECKS.description | The number of AP Checks found from Rest Sites | 休憩所で発見されたAPチェックの数 | — | — |
| J068 | AP_REWARD_PRESS_START_CHECK.title | Pressed Start | ラン開始済み | — | — |
| J069 | AP_REWARD_PRESS_START_CHECK.description | Whether this character has earned a check by starting a run. | このキャラクターがラン開始によるチェックを獲得済みかどうか | — | — |
| J070 | AP_REWARD_CLEARED_CHECK.title | Slayed the Spire | 塔を討伐済み | 塔を踏破済み | 塔に「討伐」は不自然。目標表示の「踏破」と揃える。 |
| J071 | AP_REWARD_CLEARED_CHECK.description | Whether this character has earned a check by completing a run. | このキャラクターがラン完了によるチェックを獲得済みかどうか | — | — |
| J072 | AP_REWARD_CARD_REWARDS.title | Card Rewards | カード報酬 | — | — |
| J073 | AP_REWARD_CARD_REWARDS.description | The number of Card Rewards received for this character. You can redeem these at the start of each run. | このキャラクターが受け取ったカード報酬の数。各ランの開始時に交換できる。 | — | — |
| J074 | AP_REWARD_RARE_CARD_REWARDS.title | Rare Card Rewards | レアカード報酬 | — | — |
| J075 | AP_REWARD_RARE_CARD_REWARDS.description | The number of Rare Card Rewards received for this character. You can redeem these at the start of each run. | このキャラクターが受け取ったレアカード報酬の数。各ランの開始時に交換できる。 | — | — |
| J076 | AP_REWARD_RELIC_REWARDS.title | Relic Rewards | レリック報酬 | — | — |
| J077 | AP_REWARD_RELIC_REWARDS.description | The number of Relic Rewards received for this character. You can redeem these at the start of each run. | このキャラクターが受け取ったレリック報酬の数。各ランの開始時に交換できる。 | — | — |
| J078 | AP_REWARD_PROGRESSIVE_ANCIENTS.title | Progressive Ancients | プログレッシブ古代レリック | 古代の存在の段階解放（仮） | Ancientsの指示対象とProgressiveの命名方針を確認する。 |
| J079 | AP_REWARD_PROGRESSIVE_ANCIENTS.description | The number of Progressive Ancients received for this character. You can redeem these at their usual location. | このキャラクターが受け取ったプログレッシブ古代レリックの数。通常の出現場所で交換できる。 | — | — |
| J080 | AP_REWARD_POTION_REWARDS.title | Potion Rewards | ポーション報酬 | — | — |
| J081 | AP_REWARD_POTION_REWARDS.description | The number of Potion Rewards received for this character. You can redeem these at the start of each run. | このキャラクターが受け取ったポーション報酬の数。各ランの開始時に交換できる。 | — | — |
| J082 | AP_REWARD_GOLD_REWARDS.title | Gold | ゴールド | — | — |
| J083 | AP_REWARD_GOLD_REWARDS.description | The total amount of Gold received for this character. You can redeem this at the start of each run. | このキャラクターが受け取ったゴールドの合計。各ランの開始時に交換できる。 | — | — |
| J084 | AP_REWARD_PROGRESSIVE_REST.title | Progressive Rests | プログレッシブ休憩 | 休憩の段階解放 | プログレッシブの意味を伝える案。関連表示・アイテム名と一括で揃える。 |
| J085 | AP_REWARD_PROGRESSIVE_REST.description | The number of Progressive Rest rewards received for this character. The number of these represents the highest Act you can Heal at. | このキャラクターが受け取ったプログレッシブ休憩の数。この数値は、回復を利用できる最も高いActを表す。 | このキャラクターが受け取った休憩の段階解放の数。受け取った数に応じて、回復を利用できる章が増える。 | 「最も高いAct」が読み取りにくい。Actの訳はゲーム本体と照合する。 |
| J086 | AP_REWARD_PROGRESSIVE_SMITH.title | Progressive Smiths | プログレッシブ鍛冶 | 鍛冶の段階解放 | プログレッシブの意味を伝える案。関連表示・アイテム名と一括で揃える。 |
| J087 | AP_REWARD_PROGRESSIVE_SMITH.description | The number of Progressive Smith rewards received for this character. The number of these represents the highest Act you can Upgrade at. | このキャラクターが受け取ったプログレッシブ鍛冶の数。この数値は、アップグレードを利用できる最も高いActを表す。 | このキャラクターが受け取った鍛冶の段階解放の数。受け取った数に応じて、アップグレードを利用できる章が増える。 | 「最も高いAct」が読み取りにくい。Actの訳はゲーム本体と照合する。 |
| J088 | AP_REWARD_SHOP_CARD_SLOTS.title | Shop Card Slots | ショップのカード枠 | — | — |
| J089 | AP_REWARD_SHOP_CARD_SLOTS.description | The number of Shop Card Slots received for this character. You can find those at the merchant. | このキャラクターが受け取ったショップのカード枠の数。商人の店で利用できる。 | — | — |
| J090 | AP_REWARD_SHOP_NEUTRAL_SLOTS.title | Shop Neutral Card Slots | ショップの無色カード枠 | — | — |
| J091 | AP_REWARD_SHOP_NEUTRAL_SLOTS.description | The number of Shop Neutral Card Slots received for this character. You can find those at the merchant. | このキャラクターが受け取ったショップの無色カード枠の数。商人の店で利用できる。 | — | — |
| J092 | AP_REWARD_SHOP_RELIC_SLOTS.title | Shop Relic Slots | ショップのレリック枠 | — | — |
| J093 | AP_REWARD_SHOP_RELIC_SLOTS.description | The number of Shop Relic Slots received for this character. You can find those at the merchant. | このキャラクターが受け取ったショップのレリック枠の数。商人の店で利用できる。 | — | — |
| J094 | AP_REWARD_SHOP_POTION_SLOTS.title | Shop Potion Slots | ショップのポーション枠 | — | — |
| J095 | AP_REWARD_SHOP_POTION_SLOTS.description | The number of Shop Potion Slots received for this character. You can find those at the merchant. | このキャラクターが受け取ったショップのポーション枠の数。商人の店で利用できる。 | — | — |
| J096 | AP_REWARD_SHOP_REMOVES.title | Progressive Shop Card Removal | プログレッシブ・ショップカード削除 | ショップでのカード除去の段階解放 | 「削除」と「除去」の方針を決めて関連表示と揃える。 |
| J097 | AP_REWARD_SHOP_REMOVES.description | The number of Progressive Shop Card Removals received for this character. You can find those at the merchant. | このキャラクターが受け取ったプログレッシブ・ショップカード削除の数。商人の店で利用できる。 | — | — |
| J098 | AP_REWARD_SHOPSANITY_CHECKS.title | ShopSanity Checks | ショップサニティチェック | — | — |
| J099 | AP_REWARD_SHOPSANITY_CHECKS.description | The number of AP checks found at the shop | ショップで発見されたAPチェックの数 | — | — |
| J100 | AP_REWARD_PROGRESSIVE_STARTER_CARD.title | Progressive Starter Card | プログレッシブ初期カード | — | — |
| J101 | AP_REWARD_PROGRESSIVE_STARTER_CARD.description | The number of Progressive Starter Card items received for this character. For supported characters: none, the normal starter card, then its Archaic Tooth transformation. | このキャラクターが受け取ったプログレッシブ初期カードの数。対応キャラクターでは「なし」から通常の初期カード、さらに古の牙による変化へと進む。 | — | — |
| J102 | AP_REWARD_PROGRESSIVE_STARTER_RELIC.title | Progressive Starter Relic | プログレッシブ初期レリック | — | — |
| J103 | AP_REWARD_PROGRESSIVE_STARTER_RELIC.description | The number of Progressive Starter Relic items received for this character. For supported characters: none, the normal starter relic, then its Touch of Orobas refinement. | このキャラクターが受け取ったプログレッシブ初期レリックの数。対応キャラクターでは「なし」から通常の初期レリック、さらにオロバスの接触による強化へと進む。 | — | — |
| J104 | ARCHIPELAGO_TOPBARBUTTON_PROGRESSIVE_REST.title | Rest Availability | 休憩の利用可否 | — | — |
| J105 | ARCHIPELAGO_TOPBARBUTTON_PROGRESSIVE_REST.description | Shows whether Rest is available in the current Act. A green check means enabled; a red X means you still need this Act's Progressive Rest. Rest is always enabled when Campfire Sanity is off. | 現在のActで休憩を利用できるかを示す。緑のチェックは利用可能、赤い×はこのAct用のプログレッシブ休憩がまだ必要であることを表す。焚き火サニティが無効の場合、休憩は常に利用できる。 | — | — |
| J106 | ARCHIPELAGO_TOPBARBUTTON_PROGRESSIVE_SMITH.title | Smith Availability | 鍛冶の利用可否 | — | — |
| J107 | ARCHIPELAGO_TOPBARBUTTON_PROGRESSIVE_SMITH.description | Shows whether Smith is available in the current Act. A green check means enabled; a red X means you still need this Act's Progressive Smith. Smith is always enabled when Campfire Sanity is off. | 現在のActで鍛冶を利用できるかを示す。緑のチェックは利用可能、赤い×はこのAct用のプログレッシブ鍛冶がまだ必要であることを表す。焚き火サニティが無効の場合、鍛冶は常に利用できる。 | — | — |

## C#のアイテム名・キャラクター名

修正元：`client/StS2AP/Utils/ItemNameLocalization.cs`。通信に使う英語名は保持し、表示用の日本語を修正する。キャラクター別アイテムは「キャラクター名：アイテム名」の形で組み立てられる。

| ID | 英語名 | 現在の日本語 | 修正案 |
| --- | --- | --- | --- |
| I001 | Free Attack | 次のアタックを0コスト化 | — |
| I002 | Free Power | 次のパワーを0コスト化 | — |
| I003 | Free Skill | 次のスキルを0コスト化 | — |
| I004 | Dexterity | 敏捷性 | — |
| I005 | Strength | 筋力 | — |
| I006 | Plating | プレートアーマー | — |
| I007 | Friendship | 友情 | — |
| I008 | Post-Combat Card Upgrade | 戦闘後のカードアップグレード | — |
| I009 | Post-Combat Card Removal | 戦闘後のカード削除 | — |
| I010 | Additional Card Reward | 追加のカード報酬 | — |
| I011 | Buffer | バッファー | — |
| I012 | Vigor | 活力 | — |
| I013 | Thorns | トゲ | — |
| I014 | Artifact | アーティファクト | — |
| I015 | Ironclad | アイアンクラッド | — |
| I016 | Silent | サイレント | — |
| I017 | Defect | ディフェクト | — |
| I018 | Regent | リージェント | — |
| I019 | Necrobinder | ネクロバインダー | — |
| I020 | Card Reward | カード報酬 | — |
| I021 | Rare Card Reward | レアカード報酬 | — |
| I022 | Relic | レリック | — |
| I023 | Progressive Ancient | プログレッシブ古代レリック | — |
| I024 | One Gold | 1ゴールド | — |
| I025 | Five Gold | 5ゴールド | — |
| I026 | Combat Gold | 通常戦闘ゴールド | — |
| I027 | Elite Gold | エリート戦ゴールド | — |
| I028 | Boss Gold | ボス戦ゴールド | — |
| I029 | Progressive Rest | プログレッシブ休憩 | — |
| I030 | Progressive Smith | プログレッシブ鍛冶 | — |
| I031 | Shop Card Slot | ショップのカード枠 | — |
| I032 | Neutral Shop Card Slot | ショップの無色カード枠 | — |
| I033 | Shop Relic Slot | ショップのレリック枠 | — |
| I034 | Shop Potion Slot | ショップのポーション枠 | — |
| I035 | Progressive Shop Remove | プログレッシブ・ショップカード削除 | — |
| I036 | Unlock | キャラクター解放 | — |
| I037 | Potion | ポーション | — |
| I038 | Progressive Starter Card | プログレッシブ初期カード | — |
| I039 | Progressive Starter Relic | プログレッシブ初期レリック | — |
| I040 | Victory | 勝利 | — |
| I041 | Beat Act 1 Boss | Act 1ボス撃破 | — |
| I042 | Beat Act 2 Boss | Act 2ボス撃破 | — |

## C#に直接書かれた画面表示

原文との対応はこの抽出だけでは確定できないため、ファイル・行番号と現在の実装を記載。アイテム名辞書、生成ファイル、コメントは除外。動的な文言は変数を含む実装行で示す。

| ID | 修正元 | 現在の実装 | 修正案 |
| --- | --- | --- | --- |
| U001 | client/StS2AP/ArchipelagoClient.cs:637 | string locText = $"{loc.Value.Player.Name}への{ItemNameLocalization.ToJapanese(loc.Value.ItemDisplayName)}"; | — |
| U002 | client/StS2AP/Models/ArchipelagoReward.cs:111 | TextUtility.RegisterLocString(key, $"{ItemNameLocalization.ToJapanese(_location?.ItemDisplayName ?? locationName)}（受取済み）", "ap"); | — |
| U003 | client/StS2AP/Patches/Patches_MainMenuBehavior.cs:141 | singleplayerButton!.label!.Text = "プレイ"; | — |
| U004 | client/StS2AP/Patches/Patches_MainMenuBehavior.cs:144 | settingsButton!.label!.Text = "ゲーム設定"; | — |
| U005 | client/StS2AP/Patches/Patches_MainMenuBehavior.cs:152 | archipelagoSettingsButton.label.Text = "Archipelago設定"; | — |
| U006 | client/StS2AP/Patches/Patches_MainMenuBehavior.cs:161 | installWorldButton.label.Text = "APWorldをインストール"; | — |
| U007 | client/StS2AP/Patches/Patches_MainMenuBehavior.cs:170 | visitWebsiteButton.label.Text = "Modサイト・YAML作成"; | — |
| U008 | client/StS2AP/Patches/Patches_PauseMenuBehavior.cs:105 | settingsLabel.SetTextAutoSize("ゲーム設定"); | — |
| U009 | client/StS2AP/Patches/Patches_PauseMenuBehavior.cs:114 | saveAndQuitLabel.SetTextAutoSize("終了"); | — |
| U010 | client/StS2AP/Patches/Patches_PauseMenuBehavior.cs:133 | existingLabel.SetTextAutoSize("Archipelago設定"); | — |
| U011 | client/StS2AP/Patches/Patches_PauseMenuBehavior.cs:172 | label.SetTextAutoSize("Archipelago設定"); | — |
| U012 | client/StS2AP/UI/ArchipelagoCharTrackerUI.cs:232 | SetContent("[gold]発見したチェック[/gold]                                 [gold]受信アイテム[/gold]"); | — |
| U013 | client/StS2AP/UI/ArchipelagoCharTrackerUI.cs:442 | _contentLabel.Text = "[gold]発見したチェック[/gold]                                 [gold]受信アイテム[/gold]"; | — |
| U014 | client/StS2AP/UI/ArchipelagoConnectionUI.cs:209 | title.Text = "Archipelago接続"; | — |
| U015 | client/StS2AP/UI/ArchipelagoConnectionUI.cs:223 | vbox.AddChild(CreateLabeledInput("スロット名：", "スロット名を入力…", out _slotNameInput)); | — |
| U016 | client/StS2AP/UI/ArchipelagoConnectionUI.cs:228 | vbox.AddChild(CreateLabeledInput("サーバーURL：", "archipelago.gg:38281", out _urlInput)); | — |
| U017 | client/StS2AP/UI/ArchipelagoConnectionUI.cs:233 | vbox.AddChild(CreateLabeledInput("パスワード：", "（任意）", out _passwordInput, isSecret: true)); | — |
| U018 | client/StS2AP/UI/ArchipelagoConnectionUI.cs:250 | _closeButton = CreateStyledButton("閉じる", new Color(0.5f, 0.5f, 0.5f)); | — |
| U019 | client/StS2AP/UI/ArchipelagoConnectionUI.cs:256 | _connectButton = CreateStyledButton("接続", new Color(0.2f, 0.6f, 0.3f)); | — |
| U020 | client/StS2AP/UI/ArchipelagoConnectionUI.cs:487 | SetStatus("スロット名を入力してください"); | — |
| U021 | client/StS2AP/UI/ArchipelagoConnectionUI.cs:494 | SetStatus("サーバーURLを入力してください"); | — |
| U022 | client/StS2AP/UI/ArchipelagoConnectionUI.cs:500 | SetStatus("接続中…"); | — |
| U023 | client/StS2AP/UI/ArchipelagoConnectionUI.cs:544 | SetStatus("接続しました！"); | — |
| U024 | client/StS2AP/UI/ArchipelagoConnectionUI.cs:555 | SetStatus("接続できませんでした。入力内容を確認して、もう一度お試しください。"); | — |
| U025 | client/StS2AP/UI/ArchipelagoGoalTrackerUI.cs:176 | SetContent($"[gold]目標：{charsToGoal}人のキャラクターで塔を踏破[/gold]\n進捗：{GameUtility.GoaledCharactersCount} / {charsToGoal}"); | — |
| U026 | client/StS2AP/UI/ArchipelagoRewardUI.cs:406 | data.ItemName = "レリックを選択"; | — |
| U027 | client/StS2AP/UI/ArchipelagoRewardUI.cs:413 | data.ItemName = "レリックを選択できない"; | — |
| U028 | client/StS2AP/UI/ArchipelagoRewardUI.cs:423 | data.ItemName = "古代レリックを選択"; | — |
| U029 | client/StS2AP/UI/ArchipelagoRewardUI.cs:430 | data.ItemName = "古代レリックを選択できない"; | — |
| U030 | client/StS2AP/UI/ArchipelagoRewardUI.cs:972 | Text                = "Archipelago戦利品！", | — |
| U031 | client/StS2AP/UI/ArchipelagoRewardUI.cs:1012 | Text              = "スキップ", | — |
| U032 | client/StS2AP/UI/ArchipelagoRewardUI.cs:1498 | _proceedButton.Text = _remainingRewards > 0 ? "スキップ" : "進む"; | — |
| U033 | client/StS2AP/Utils/NotificationUtility.cs:402 | $"[color=magenta]{info.Player}[/color]から次のターン用に[sine][color=yellow]{ItemNameLocalization.ToJapanese(info.ItemDisplayName)}[/color][/sine]が届いた！"; | — |

件数：JSON 107件、名称辞書 42件、C#画面表示 33行。

修正したい項目はIDで指定できる（例：`J001 → 新しい訳`）。同じ用語が複数箇所にある場合は関連項目も合わせて修正する。
