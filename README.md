# MiniSteamAuthenticator

MiniSteamAuthenticator is a desktop 2FA code generator app for Steam. It is coded in easily auditable C# and contains no other unnecessary functions.

## Usage

MiniSteamAuthenticator accepts Base32 encoded Steam shared secret as used in Aegis or andOTP.
You can use `steamctl` to generate the shared secret. https://github.com/ValvePython/steamctl

1. Install steamctl

    `pip install steamctl`
    
2. Generate an authentication token using steamctl

    `steamctl authenticator add`

3. Export saved authentication token as a QR code

    `steamctl authenticator qrcode YOUR_USERNAME`

4. Scan the QR code with an external application. It will be formatted like this:

    `otpauth://steam/steamctl:YOUR_USERNAME?secret=XXXXXX&issuer=Steam`

5. Copy the secret value and add it to the configuration .ini file.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## Credits
This program uses SteamAuth library written by @geel9