Feature: Check Google Home
  As a user
  I want to navigate to www.google.com
  So that I can see an empty search field in the home page

  Scenario: Check if the Google Search field is empty
    Given the user has an open browser
    When the user navigates to the google home page
    Then the user sees an empty textbox
