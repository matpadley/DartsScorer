import XCTest
@testable import DartsEngine

class PlayerTests: XCTestCase {

    func testPlayerInitialization() {
        let playerName = "John Doe"
        let player = Player(name: playerName)
        
        XCTAssertEqual(player.name, playerName, "Player name should be initialized correctly")
    }
}
