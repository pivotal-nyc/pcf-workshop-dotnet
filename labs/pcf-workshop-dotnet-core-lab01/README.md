﻿## LAB 1: DEPLOY

### STEP 1 - DEFAULT PUSH

1. Navigate to the folder containing the lab 1 project files.
2. Without making any changes, publish a Release build.

		dotnet publish -c Release

3. Navigate to the publish folder and deploy the app.

		cf push [app-name]-[your-name]-lab01

4. Navigate to url from the PCF dashboard.

### STEP 2 - MANIFEST PUSH

1. Open the manifest.yml file included in the project.
2. Add the following settings to the file.

		```
		---
		applications:
		-   name: [app-name]-[your-name]-lab01
			buildpack: binary_buildpack
			stack: windows2016
			instances: 1
			disk: 512M
			memory: 512M
			health-check-type: none
			command: cmd /c .\pcf-workshop-dotnet-core-lab01 --server.urls http://*:%PORT%
		```

3. In the Configure method of the Startup.cs file, change the "Hello World!" text.
4. Publish a Release build.
5. Change directory to Release folder (ensure manifest.yml was published).
6. Push app.

	cf push

7. Navigate to url from the PCF dashboard.

8. Confirm the new value is output on the page.
	
### STEP 3 - SCALE

1. Observe instance count, memory, disk size from apps manager or CLI.

	cf app [app-name]-[your-name]-lab01

2. Double the instance count, memory, and disk size.

	cf scale [app-name]-[your-name]-lab01 -i 2 -k 500M -m 500M

3. Observe updates in Apps Manager or CLI.

	cf app [app-name]-[your-name]-lab01