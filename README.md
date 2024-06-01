---

# Proxy Checker User Guide

Proxy Checker is a tool used to test given proxy addresses and determine whether they are working or not. This guide explains how to use Proxy Checker step by step.

## Installation

1. In order to run this application, you need to have .NET Framework 4.7.2 or later installed on your computer.

2. Download the latest version of the application from the GitHub page or project repository.

3. Extract the downloaded file to a folder and double-click the .exe file to launch the application.

## Usage

1. When the application starts, you will first be prompted to select a proxy type (Proxy4 or Proxy5).

2. Enter the proxy addresses you want to test into the "Enter Proxy Addresses" field. Write each proxy address on a separate line.

3. Click the "Test" button to start the proxy test.

4. As the test begins, a result will be displayed for each proxy address. Successful ones will be marked as "SUCCESS" and unsuccessful ones as "ERROR".

5. Once the process is complete, you can click the "Save to File" button to save the tested proxy addresses to a file.

## Notes

- The application uses HTTP GET requests to determine whether a specific proxy address is working or not. Therefore, the accuracy of the test will depend on your internet connection and the status of the proxy server.

- Proxy addresses should be in the correct format (e.g., "IP:Port").

- When you click the "Save to File" button, a text file containing the tested proxy addresses will be created. This file will be saved to the directory where the application is running.

This guide covers the basic usage of Proxy Checker. For more information or support, you can refer to the project repository.

---
