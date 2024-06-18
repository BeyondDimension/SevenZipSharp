namespace SevenZip;

[BinaryResource(
"""
[
""" +
#if SFX
"""

  {
    "Path": "..\\res\\sfx\\7z.sfx",
    "Name": "sfx_7z_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zCon.sfx",
    "Name": "sfx_7zCon_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zS.sfx",
    "Name": "sfx_7zS_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zSD.sfx",
    "Name": "sfx_7zSD_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zxSD_All.sfx",
    "Name": "sfx_7zxSD_All_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zxSD_All_x64.sfx",
    "Name": "sfx_7zxSD_All_x64_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zxSD_Deflate.sfx",
    "Name": "sfx_7zxSD_Deflate_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zxSD_Deflate_x64.sfx",
    "Name": "sfx_7zxSD_Deflate_x64_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zxSD_LZMA.sfx",
    "Name": "sfx_7zxSD_LZMA_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zxSD_LZMA_x64.sfx",
    "Name": "sfx_7zxSD_LZMA_x64_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zxSD_LZMA2.sfx",
    "Name": "sfx_7zxSD_LZMA2_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zxSD_LZMA2_x64.sfx",
    "Name": "sfx_7zxSD_LZMA2_x64_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zxSD_PPMd.sfx",
    "Name": "sfx_7zxSD_PPMd_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\7zxSD_PPMd_x64.sfx",
    "Name": "sfx_7zxSD_PPMd_x64_sfx",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\Configs.xml",
    "Name": "sfx_Configs_xml",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\Configs.xsd",
    "Name": "sfx_Configs_xsd",
    "Reverse": true
  },
  {
    "Path": "..\\res\\sfx\\Configs.xslt",
    "Name": "sfx_Configs_xslt",
    "Reverse": true
  },
""" +
#endif
"""
  {
    "Path": "..\\res\\arch\\Test.bzip2.7z",
    "Name": "arch_Test_bzip2_7z",
    "Reverse": true
  },
  {
    "Path": "..\\res\\arch\\Test.lzma.7z",
    "Name": "arch_Test_lzma_7z",
    "Reverse": true
  },
  {
    "Path": "..\\res\\arch\\Test.lzma2.7z",
    "Name": "arch_Test_lzma2_7z",
    "Reverse": true
  },
  {
    "Path": "..\\res\\arch\\Test.ppmd.7z",
    "Name": "arch_Test_ppmd_7z",
    "Reverse": true
  },
  {
    "Path": "..\\res\\arch\\Test.rar",
    "Name": "arch_Test_rar",
    "Reverse": true
  },
  {
    "Path": "..\\res\\arch\\Test.tar",
    "Name": "arch_Test_tar",
    "Reverse": true
  },
  {
    "Path": "..\\res\\arch\\Test.txt",
    "Name": "arch_Test_txt",
    "Reverse": true
  },
  {
    "Path": "..\\res\\arch\\Test.txt.bz2",
    "Name": "arch_Test_txt_bz2",
    "Reverse": true
  },
  {
    "Path": "..\\res\\arch\\Test.txt.gz",
    "Name": "arch_Test_txt_gz",
    "Reverse": true
  },
  {
    "Path": "..\\res\\arch\\Test.txt.xz",
    "Name": "arch_Test_txt_xz",
    "Reverse": true
  },
  {
    "Path": "..\\res\\arch\\Test.zip",
    "Name": "arch_Test_zip",
    "Reverse": true
  }
]
""",
"""
    internal static byte[] GetManifestResource(string fileName, string dirName) => dirName switch
    {
        "arch" => fileName switch
        {
            "Test.bzip2.7z" => {arch_Test_bzip2_7z}(),
            "Test.lzma.7z" => {arch_Test_lzma_7z}(),
            "Test.lzma2.7z" => {arch_Test_lzma2_7z}(),
            "Test.ppmd.7z" => {arch_Test_ppmd_7z}(),
            "Test.rar" => {arch_Test_rar}(),
            "Test.tar" => {arch_Test_tar}(),
            "Test.txt" => {arch_Test_txt}(),
            "Test.txt.bz2" => {arch_Test_txt_bz2}(),
            "Test.txt.gz" => {arch_Test_txt_gz}(),
            "Test.txt.xz" => {arch_Test_txt_xz}(),
            "Test.zip" => {arch_Test_zip}(),
            _ => [],
        },
#if SFX
        "sfx" => fileName switch
        {
            "7z.sfx" => {sfx_7z_sfx}(),
            "7zCon.sfx" => {sfx_7zCon_sfx}(),
            "7zS.sfx" => {sfx_7zS_sfx}(),
            "7zSD.sfx" => {sfx_7zSD_sfx}(),
            "7zxSD_All.sfx" => {sfx_7zxSD_All_sfx}(),
            "7zxSD_All_x64.sfx" => {sfx_7zxSD_All_x64_sfx}(),
            "7zxSD_Deflate.sfx" => {sfx_7zxSD_Deflate_sfx}(),
            "7zxSD_Deflate_x64.sfx" => {sfx_7zxSD_Deflate_x64_sfx}(),
            "7zxSD_LZMA.sfx" => {sfx_7zxSD_LZMA_sfx}(),
            "7zxSD_LZMA_x64.sfx" => {sfx_7zxSD_LZMA_x64_sfx}(),
            "7zxSD_LZMA2.sfx" => {sfx_7zxSD_LZMA2_sfx}(),
            "7zxSD_LZMA2_x64.sfx" => {sfx_7zxSD_LZMA2_x64_sfx}(),
            "7zxSD_PPMd.sfx" => {sfx_7zxSD_PPMd_sfx}(),
            "7zxSD_PPMd_x64.sfx" => {sfx_7zxSD_PPMd_x64_sfx}(),
            "Configs.xml" => {sfx_Configs_xml}(),
            "Configs.xsd" => {sfx_Configs_xsd}(),
            "Configs.xslt" => {sfx_Configs_xslt}(),
            _ => [],
        },
#endif
        _ => [],
    };
""")]
partial class LibraryManager
{
}