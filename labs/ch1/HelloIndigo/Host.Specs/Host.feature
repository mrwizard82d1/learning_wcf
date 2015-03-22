Feature: Run Service Host
  In order to learn to test a hosted, running WCF service
  As a developer
  I want to test a running, hosted WCF service

Scenario: Query greeting
  Given that I have started the host
  When I execute the "HelloIndigo" method of the service
  Then I receive "Hello Indigo" as a result
