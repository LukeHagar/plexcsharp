# GetUsersMediaContainer

Container holding user and server details.


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 | Example                                                     |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `FriendlyName`                                              | *string*                                                    | :heavy_check_mark:                                          | The friendly name of the Plex instance.                     | myPlex                                                      |
| `Identifier`                                                | *string*                                                    | :heavy_check_mark:                                          | N/A                                                         | com.plexapp.plugins.myplex                                  |
| `MachineIdentifier`                                         | *string*                                                    | :heavy_check_mark:                                          | Unique Machine identifier of the Plex server.               | 3dff4c4da3b1229a649aa574a9e2b419a684a20e                    |
| `TotalSize`                                                 | *long*                                                      | :heavy_check_mark:                                          | Total number of users.                                      | 30                                                          |
| `Size`                                                      | *long*                                                      | :heavy_check_mark:                                          | Number of users in the current response.                    | 30                                                          |
| `User`                                                      | List<[Models.Requests.User](../../Models/Requests/User.md)> | :heavy_check_mark:                                          | List of users with access to the Plex server.               |                                                             |