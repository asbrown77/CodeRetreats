.\packages\NUnit.Runners.2.6.4\tools\nunit-console.exe /labels /out=TestResult.txt /xml=TestResult.xml MathAssistant.AcceptanceTests\bin\debug\MathAssistant.AcceptanceTests.dll

.\packages\Pickles.CommandLine.2.17.0\tools\pickles.exe --f=MathAssistant.AcceptanceTests\Features^ -o=.\document\ --lr=.\TestResult.xml --df=dhtml

pause



.\document\index.html

