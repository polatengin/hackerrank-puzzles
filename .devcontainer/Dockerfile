FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster

# Avoid warnings by switching to noninteractive
ENV DEBIAN_FRONTEND=noninteractive

# Configure apt and install packages
RUN apt-get update \
  #
  # Verify wget, jq, unzip, git and process tools installed
  && apt-get -y install git iproute2 procps wget unzip jq \
