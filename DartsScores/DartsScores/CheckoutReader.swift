import Foundation

class CheckoutReader
{
    var data: [String: Any]?

    init() {
        loadJSON()
    }

    private func loadJSON() {
        if let path = Bundle.main.path(forResource: "checkout", ofType: "json") {
            do {
                let data = try Data(contentsOf: URL(fileURLWithPath: path))
                self.data = try JSONSerialization.jsonObject(with: data, options: []) as? [String: Any]
            } catch {
                print("Error loading JSON: \(error)")
            }
        }
    }

    func getArray(for number: Int) -> [Any]? {
        guard let data = data else {
            return nil
        }
        return data["\(number)"] as? [Any]
    }
}
