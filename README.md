# AbpDemo
AbpDemo
# abp cli 常用命令
dotnet tool update -g Volo.Abp.Cli

abp new Parakeet.Net -dbms PostgreSQL --tiered -csf  --version 6.0.2

abp new Parakeet.Net -t app-nolayers -csf --version 6.0.2

abp new Parakeet.Net -t module -csf --version 6.0.2

abp new Parakeet.Net-t module --no-ui -csf --version 6.0.2

abp new Parakeet.Net -t app-nolayers --theme basic -csf --version 6.0.2


# 如果装错了，可以移除cli工具，再重新装指定版本
abp cli remove
dotnet tool install -g Volo.Abp.Cli --version 6.0.2

# mvc前端安装libs依赖命令 会自动把最小依赖安装包自动安装到 /wwwroot/libs 目录下
abp install-libs --version 6.0.2

