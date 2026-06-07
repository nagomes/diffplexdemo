# DiffPlex Demo - WinForm 文件差异对比工具

这是一个基于 .NET Framework 4.7.2 的 WinForm 应用程序，使用 DiffPlex 库来显示两个文件之间的差异。

## 功能特性

- 📂 **打开文件** - 支持打开 txt、cs 等文本文件
- 🔍 **文件对比** - 使用 DiffPlex 库进行高效的差异分析
- 📊 **差异统计** - 显示添加、删除、修改的行数统计
- 🎨 **友好的UI** - 分屏显示两个文件内容，对比结果清晰直观
- 🧹 **清空功能** - 一键清空所有内容重新开始

## 系统要求

- Windows OS
- .NET Framework 4.7.2 或更高版本
- Visual Studio 2015 或更高版本（用于开发）

## 项目结构

```
DiffPlexDemo/
├── MainForm.cs           # 主窗体逻辑代码
├── MainForm.Designer.cs  # 窗体设计器生成代码
├── Program.cs            # 程序入口点
├── DiffPlexDemo.csproj   # 项目文件
├── App.config            # 应用配置文件
├── packages.config       # NuGet 包配置
└── README.md             # 本文件
```

## 依赖库

- **DiffPlex** (v1.6.3) - 用于比较和生成差异信息的库

## 使用说明

1. **打开文件1** - 点击"打开文件1"按钮，选择第一个要对比的文件
2. **打开文件2** - 点击"打开文件2"按钮，选择第二个要对比的文件
3. **开始对比** - 点击"开始对比"按钮，程序将显示两个文件的差异
4. **查看结果** - 下方结果区域会显示：
   - 总行数
   - 添加行数（用 `+ ` 标记）
   - 删除行数（用 `- ` 标记）
   - 修改行数（用 `~ ` 标记）
5. **清空** - 点击"清空"按钮重置所有数据

## 编译与运行

### 方式一：使用 Visual Studio

1. 用 Visual Studio 打开 `DiffPlexDemo.csproj`
2. 在 NuGet Package Manager 中安装依赖：`DiffPlex v1.6.3`
3. 编译项目（Ctrl+Shift+B）
4. 运行程序（F5）

### 方式二：使用命令行

```bash
# 还原 NuGet 包
msbuild DiffPlexDemo.csproj /t:Restore

# 编译项目
msbuild DiffPlexDemo.csproj /p:Configuration=Release

# 运行编译后的程序
.\bin\Release\DiffPlexDemo.exe
```

## 特性演示

- **同步滚动** - 左右两个文件内容框支持独立滚动
- **等宽字体** - 使用 Courier New 字体确保对齐
- **结果展示** - 清晰的差异标记和统计信息

## 技术实现

### DiffPlex 集成

```csharp
var diffBuilder = new SideBySideDiffBuilder(new DiffPlex.Differ());
var diffResult = diffBuilder.BuildDiffModel(text1, text2);
```

### UI 布局

- 上方：工具栏（打开文件、开始对比、清空按钮）
- 中部：分屏显示两个文件的内容
- 下方：对比结果显示区域

## 许可证

本项目仅供学习和演示之用。

## 作者

Created by nagomes - 2026

## 更新日志

### v1.0.0 (2026-06-07)
- 初始版本发布
- 实现基本的文件对比功能
- 支持统计信息显示
- 提供清晰的用户界面
