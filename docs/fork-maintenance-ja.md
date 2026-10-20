# このフォークの更新方法

このフォークは、日本語表示とmacOS向けの設定、および独自のレリッククーポン表示を保持する。

- `origin`: https://github.com/hatosableSAN/Slay-the-Spire-2-Archipelago.git
- `upstream`: https://github.com/dlueben1/Slay-the-Spire-2-Archipelago.git
- `main`: 上流最新版と独自変更を統合した作業ブランチ
- `local-preserved`: 2026年10月21日の更新前ソースを保存したブランチ

`local-preserved` は、既存ファイルとの一致数が最も多かった上流コミット `eca00b6` をベースに作成した。246ファイル中229ファイルが完全一致したが、元のZIPにGit履歴がないためベースは推定である。秘密情報のパターンを点検し、上流と同一の `.env` 以外のローカル設定、ビルド生成物はコミット対象から除いた。`build/` や `local.props` はローカルに保持する。

## フォークの変更を取得する

```sh
git switch main
git pull --ff-only origin main
```

## 本家の更新を取り込む

未コミットの変更がある場合は、先にコミットする。

```sh
git switch main
git status
git fetch upstream
git merge upstream/main
```

競合が出た場合は独自変更と上流の実装を確認して解決し、ビルド確認後に保存する。

```sh
git push origin main
```

通常の `git pull` は自分のフォークを取得する。本家の更新には `git fetch upstream` と `git merge upstream/main` を使う。

## 保存した旧版を別フォルダで確認する

```sh
git worktree add ../StS2AP-before-update local-preserved
```

元フォルダ全体の更新前バックアップはローカルの `.git/local-backup-20261021.tar.gz` にある。このアーカイブにはローカル設定や生成物も含まれ、GitHubには送信しない。

## 今回の統合

上流 `0a8cf27` を取り込み、移動・再設計されたメニューと報酬表示に日本語表示を移植した。レリッククーポンの表示は「保有クーポン数 − 自然報酬を待つ受信レリック数」を維持し、上流の新しいマルチプレイ処理と互換ビルド構成を残した。旧版のLasting Candy用パッチは上流で削除されているため復活させていない。

ソースの更新とコンパイル確認までを行い、ゲームへのMOD配置・実機プレイ確認は行っていない。上流で追加された表示文や日本語リソースに存在しないキーは英語のままの場合がある。
