using SUS.Atomic.Base.Interfaces;
using SUS.AtomicAssets.Client.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
namespace SUS.AtomicAssets.Client
{
    public static class LimitableExtensionMethods
    {
        public static Type Limit<Type>(this ILimitable<Type> limitable, int limit)
        {
            limitable.AddQuery("limit", limit.ToString());
            return (Type)limitable;
        }
    }
    public static class OrderableExtensionMethods
    {
        public static Type Order<Type>(this IOrderable<Type> orderable, bool ascending = true)
        {
            if (ascending)
                orderable.AddQuery("order", "asc");
            else
                orderable.AddQuery("order", "desc");
            return (Type)orderable;
        }
    }
    public static class ExecutableExtensionMethods
    {
        public static async Task<Response> Execute<Response>(this IExecutable<Response> executable, IHttpClientFactory factory)
        {
            var client = factory.CreateClient();
            var response = await client.GetAsync(executable.GetURI());
            Response result = await response.Content.ReadAsAsync<Response>();
            return result;
        }
        public static async Task<Response> Execute<Response>(this IExecutable<Response> executable)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(executable.GetURI());
            if (response.IsSuccessStatusCode)
            {
                Response result = await response.Content.ReadAsAsync<Response>();
                return result;
            }
            ErrorResponse errorResponse = await response.Content.ReadAsAsync<ErrorResponse>();
            throw new Exception(errorResponse.Message);
        }
    }

    public static class PageableExtensionMethods
    {
        public static Type Page<Type>(this IPageable<Type> pageable, int page)
        {
            pageable.AddQuery("page", page.ToString());
            return (Type)pageable;
        }
    }
    public static class SchemaFilterableExtensionMethods
    {
        public static Type Schema<Type>(this ISchemaFilterable<Type> schemaFilterable, string schema)
        {
            schemaFilterable.AddQuery("schema_name", schema);
            return (Type)schemaFilterable;
        }
    }
    public static class CollectionFilterableExtensionMethods
    {
        public static Type Collection<Type>(this ICollectionFilterable<Type> collectionFilterable, string collection)
        {
            collectionFilterable.AddQuery("collection_name", collection);
            return (Type)collectionFilterable;
        }
    }

    public static class OwnerMatchableExtensionMethods
    {
        public static Type OwnerMatch<Type>(this IOwnerMatchable<Type> ownerMatchable, string ownerMatch)
        {
            ownerMatchable.AddQuery("match_owner", ownerMatch);
            return (Type)ownerMatchable;
        }
    }

    public static class TemplateFilterableExtensionMethods
    {
        public static Type Template<Type>(this ITemplateFilterable<Type> templateFilterable, long template)
        {
            templateFilterable.AddQuery("template_id", template.ToString());
            return (Type)templateFilterable;
        }

        public static Type Templates<Type>(this ITemplatesFilterable<Type> templatesFilterable, List<long> templates)
        {
            templatesFilterable.AddMultiArgQuery("template_id", templates.Select(t=>t.ToString()).ToList());
            return (Type)templatesFilterable;
        }
    }

    public static class BurnedAssetsFilterableExtensionMethods
    {
        public static Type Burned<Type>(this IBurnedAssetsFilterable<Type> burnedAssetsFilterable, bool burned)
        {
            burnedAssetsFilterable.AddQuery("burned", burned.ToString());
            return (Type)burnedAssetsFilterable;
        }
    }

    public static class AssetOfferFilterableExtensionMethods
    {
        public static Type HideOffers<Type>(this IAssetOfferFilterable<Type> assetOfferFilterable, bool hideOffers)
        {
            assetOfferFilterable.AddQuery("hide_offers", hideOffers.ToString());
            return (Type)assetOfferFilterable;
        }
    }

    public static class CollectionBlocklistableExtensionMethods
    {
        public static Type BlocklistCollections<Type>(this ICollectionBlocklistable<Type> collectionBlocklistable, List<string> collections)
        {
            collectionBlocklistable.AddMultiArgQuery("collection_blacklist", collections);
            return (Type)collectionBlocklistable;
        }
    }

    public static class CollectionAllowlistableExtensionMethods
    {
        public static Type AllowlistCollections<Type>(this ICollectionAllowlistable<Type> collectionAllowlistable, List<string> collections)
        {
            collectionAllowlistable.AddMultiArgQuery("collection_whitelist", collections);
            return (Type)collectionAllowlistable;
        }
    }

    public static class OwnerFilterableExtensionMethods
    {
        public static Type Owner<Type>(this IOwnerFillterable<Type> ownerFillterable, string owner)
        {
            ownerFillterable.AddQuery("owner", owner);
            return (Type)ownerFillterable;
        }

        public static Type Owners<Type>(this IOwnersFilterable<Type> ownersFilterable, List<string> owners)
        {
            ownersFilterable.AddMultiArgQuery("owner", owners);
            return (Type)ownersFilterable;
        }
    }

    public static class IdFilterableExtensionMethods
    {
        public static Type Ids<Type>(this IIdsFilterable<Type> idsFilterable, List<string> ids)
        {
            idsFilterable.AddMultiArgQuery("ids", ids);
            return (Type)idsFilterable;
        }
    }

    public static class LowerBoundableExtensionMethods
    {
        public static Type LowerBound<Type>(this ILowerBoundable<Type> lowerBoundable, long lowerBound)
        {
            lowerBoundable.AddQuery("lower_bound", lowerBound.ToString());
            return (Type)lowerBoundable;
        }
    }

    public static class UpperBoundableExtensionMethods
    {
        public static Type UpperBound<Type>(this IUpperBoundable<Type> upperBoundable, long upperBound)
        {
            upperBoundable.AddQuery("upper_bound", upperBound.ToString());
            return (Type)upperBoundable;
        }
    }

    public static class BurnedByAccountFilterableExtensionMethods
    {
        public static Type BurnedByAccounts<Type>(this IBurnedByAccountFilterable<Type> burnedByAccountFilterable, List<string> accounts)
        {
            burnedByAccountFilterable.AddMultiArgQuery("burned_by_account", accounts);
            return (Type)burnedByAccountFilterable;
        }
    }

    public static class AuthorizedAccountFilterableExtensionMethods
    {
        public static Type AuthorizedAcconts<Type>(this IAuthorizedAccountFilterable<Type> authorizedAccountFilterable, string account)
        {
            authorizedAccountFilterable.AddQuery("authorized_account", account);
            return (Type)authorizedAccountFilterable;
        }
    }

    public static class MatchableExtensionMethods
    {
        public static Type Match<Type>(this IMatchable<Type> matchable, string match)
        {
            matchable.AddQuery("match", match);
            return (Type)matchable;
        }
    }

    public static class BeforeFilterableExtensionMethods
    {
        public static Type Before<Type>(this IBeforeFilterable<Type> beforeFilterable, string before)
        {
            beforeFilterable.AddQuery("before", before);
            return (Type)beforeFilterable;
        }
    }

    public static class AfterFilterableExtensionMethods
    {
        public static Type After<Type>(this IAfterFilterable<Type> afterFilterable, string after)
        {
            afterFilterable.AddQuery("after", after);
            return (Type)afterFilterable;
        }
    }

    public static class SortableExtensionMethods
    {
        public static Type Sort<Type, Enum>(this ISortable<Type, Enum> sortable, Enum sort)
        {
            sortable.AddQuery("sort", sort.ToString().ToLower());
            return (Type)sortable;
        }
    }

    public static class ActionAllowlistableExtensionMethods
    {
        public static Type ActionAllowlistable<Type>(this IActionAllowlistable<Type> actionAllowlistable, string action)
        {
            actionAllowlistable.AddQuery("action_whitelist", action);
            return (Type)actionAllowlistable;
        }
    }

    public static class ActionBlocklistableExtensionMethods
    {
        public static Type ActionBlocklist<Type>(this IActionBlocklistable<Type> actionBlocklistable, string action)
        {
            actionBlocklistable.AddQuery("action_blacklist", action);
            return (Type)actionBlocklistable;
        }
    }

    public static class AccountFilterableExtensionMethods
    {
        public static Type Accounts<Type>(this IAccountFilterable<Type> accountFilterable, List<string> accounts)
        {
            accountFilterable.AddMultiArgQuery("account", accounts);
            return (Type)accountFilterable;
        }
    }

    public static class SendersFilterableExtensionMethods
    {
        public static Type Senders<Type>(this ISendersFilterable<Type> sendersFilterable, List<string> senders)
        {
            sendersFilterable.AddMultiArgQuery("sender", senders);
            return (Type)sendersFilterable;
        }
    }

    public static class RecipientsFilterableExtensionMethods
    {
        public static Type Receivers<Type>(this IRecipientsFilterable<Type> recipientsFilterable, List<string> recipients)
        {
            recipientsFilterable.AddMultiArgQuery("recipient", recipients);
            return (Type)recipientsFilterable;
        }
    }

    public static class MemoFilterableExtensionMethods
    {
        public static Type Memo<Type>(this IMemoFilterable<Type> memoFilterable, string memo)
        {
            memoFilterable.AddQuery("memo", memo);
            return (Type)memoFilterable;
        }
    }

    public static class MemoMatchableExtensionMethods
    {
        public static Type MatchMemo<Type>(this IMemoMatchable<Type> memoMatchable, string match)
        {
            memoMatchable.AddQuery("memo_match", match);
            return (Type)memoMatchable;
        }
    }

    public static class StateFilterableExtensionMethods
    {
        public static Type State<Type>(this IStateFilterable<Type> stateFilterable, string state)
        {
            stateFilterable.AddQuery("state", state);
            return (Type)stateFilterable;
        }
    }

    public static class IsRecipientContractFilterableExtensionMethhods
    {
        public static Type IsRecipientContract<Type>(this IIsRecipientContractFilterable<Type> isRecipientContractFilterable, bool isRecipientContract)
        {
            isRecipientContractFilterable.AddQuery("is_recipient_contract", isRecipientContract.ToString());
            return (Type)isRecipientContractFilterable;
        }
    }

    public static class AssetFilterableExtensionMethods
    {
        public static Type Assets<Type>(this IAssetsFilterable<Type> assetsFilterable, List<string> assets)
        {
            assetsFilterable.AddMultiArgQuery("asset_id", assets);
            return (Type)assetsFilterable;
        }
    }

    public static class SearchableExtensionMethods
    {
        public static Type Search<Type>(this ISearchable<Type> searchable, string search)
        {
            searchable.AddQuery("search", search);
            return (Type)searchable;
        }
    }

    public static class NameMatchable
    {
        public static Type MatchImmutableName<Type>(this IImmutableNameMatchable<Type> nameMatchable, string name)
        {
            nameMatchable.AddQuery("match_immutable_name", name);
            return (Type)nameMatchable;
        }

        public static Type MatchMutableName<Type>(this IMutableNameMatchable<Type> nameMatchable, string name)
        {
            nameMatchable.AddQuery("match_mutable_name", name);
            return (Type)nameMatchable;
        }
    }

    public static class IsTransferableExtensionMethods
    {
        public static Type IsTransferable<Type>(this IIsTransferable<Type> isTransferable, bool isTransferableBool)
        {
            isTransferable.AddQuery("is_transferable", isTransferableBool.ToString());
            return (Type)isTransferable;
        }
    }

    public static class IsBurnableExtensionMethods
    {
        public static Type IsBurnable<Type>(this IIsBurnable<Type> isBurnable, bool isBurnableBool)
        {
            isBurnable.AddQuery("is_burnable", isBurnableBool.ToString());
            return (Type)isBurnable;
        }
    }

    public static class MinterFilterableExtensionMethods
    {
        public static Type Minter<Type>(this IMinterFilterable<Type> minterFilterable, string minter)
        {
            minterFilterable.AddQuery("minter", minter);
            return (Type)minterFilterable;
        }
    }

    public static class BurnerFilterableExtensionMethods
    {
        public static Type Burner<Type>(this IBurnerFilterable<Type> burnerFilterable, string burner)
        {
            burnerFilterable.AddQuery("burner", burner);
            return (Type)burnerFilterable;
        }
    }

    public static class InitialReceiverFilterableExtensionMethods
    {
        public static Type InitialReceiver<Type>(this IInitialReceiverFilterable<Type> initialReceiverFilterable, string initialReceiver)
        {
            initialReceiverFilterable.AddQuery("initial_receiver", initialReceiver);
            return (Type)initialReceiverFilterable;
        }
    }

    public static class OnlyDuplicateTemplatesFilterableExtensionMethods
    {
        public static Type OnlyDuplicateTemplates<Type>(this IOnlyDuplicateTemplatesFilterable<Type> onlyDuplicateTemplatesFilterable, bool onlyDuplicates)
        {
            onlyDuplicateTemplatesFilterable.AddQuery("only_duplicate_templates", onlyDuplicates.ToString());
            return (Type)onlyDuplicateTemplatesFilterable;
        }
    }

    public static class HasBackedTokensFilterableExtensionMethods
    {
        public static Type HasBackedTokens<Type>(this IHasBackedTokensFilterable<Type> hasBackedTokensFilterable, bool hasBackedTokens)
        {
            hasBackedTokensFilterable.AddQuery("has_backed_tokens", hasBackedTokens.ToString());
            return (Type)hasBackedTokensFilterable;
        }
    }

    public static class HasTemplateBuyofferFilterableExtensionMethods
    {
        public static Type HasTemplateBuyOffer<Type>(this IHasTemplateBuyofferFilterable<Type> hasTemplateBuyofferFilterable, bool hasTemplateBuyOffer)
        {
            hasTemplateBuyofferFilterable.AddQuery("has_template_buyoffer", hasTemplateBuyOffer.ToString());
            return (Type)hasTemplateBuyofferFilterable;
        }
    }

    public static class TemplateBlocklistableExtensionMethods
    {
        public static Type BlockTemplates<Type>(this ITemplateBlocklistable<Type> templateBlocklistable, List<string> templates)
        {
            templateBlocklistable.AddMultiArgQuery("template_blacklist", templates);
            return (Type)templateBlocklistable;
        }
    }

    public static class TemplateAllowlistableExtensionMethods
    {
        public static Type AllowTemplates<Type>(this ITemplateAllowlistable<Type> templateAllowlistable, List<string> templates)
        {
            templateAllowlistable.AddMultiArgQuery("template_whitelist", templates);
            return (Type)templateAllowlistable;
        }
    }

    public static class HideTemplatesByAccountsFilterableExtensionMethods
    {
        public static Type HideTemplatesByAccounts<Type>(this IHideTemplatesByAccountsFilterable<Type> hideTemplatesByAccountsFilterable, string account)
        {
            hideTemplatesByAccountsFilterable.AddQuery("hide_templates_by_accounts", account);
            return (Type)hideTemplatesByAccountsFilterable;
        }
    }

    public static class BuyerFilterableExtensionMethods
    {
        public static Type Buyer<Type>(this IBuyerFilterable<Type> buyerFilterable, string buyer)
        {
            buyerFilterable.AddQuery("buyer", buyer);
            return (Type)buyerFilterable;
        }
    }

    public static class SellerFilterableExtensionMethods
    {
        public static Type Seller<Type>(this ISellerFilterable<Type> sellerFilterable, string seller)
        {
            sellerFilterable.AddQuery("seller", seller);
            return (Type)sellerFilterable;
        }
    }

    public static class TokenSymbolFilterableExtensionMethods
    {
        public static Type TokenSymbol<Type>(this ITokenSymbolFilterable<Type> tokenSymbolFilterable, string tokenSymbol)
        {
            tokenSymbolFilterable.AddQuery("symbol", tokenSymbol);
            return (Type)tokenSymbolFilterable;
        }
    }

    public static class AuthorFilterableExtensionMethods
    {
        public static Type Author<Type>(this IAuthorFilterable<Type> authorFilterable, string author)
        {
            authorFilterable.AddQuery("author", author);
            return (Type)authorFilterable;
        }
    }

    public static class NotifyAccountFilterableExtensionMethods
    {
        public static Type NotifyAccount<Type>(this INotifyAccountFilterable<Type> notifyAccountFilterable, string notifyAccount)
        {
            notifyAccountFilterable.AddQuery("notify_account", notifyAccount);
            return (Type)notifyAccountFilterable;
        }
    }

    public static class IssuedSupplyFilterableExtensionMethods
    {
        public static Type IssuedSupply<Type>(this IIssuedSupplyFilterable<Type> issuedSupplyFilterable, int issuedSupply)
        {
            issuedSupplyFilterable.AddQuery("issued_supply", issuedSupply.ToString());
            return (Type)issuedSupplyFilterable;
        }
    }

    public static class MinIssuedSupplyFilterableExtensionMethods
    {
        public static Type MinIssuedSupply<Type>(this IMinIssuedSupplyFilterable<Type> minIssuedSupplyFilterable, int minIssuedSupply)
        {
            minIssuedSupplyFilterable.AddQuery("min_issued_supply", minIssuedSupply.ToString());
            return (Type)minIssuedSupplyFilterable;
        }
    }

    public static class MaxIssuedSupplyFilterableExtensionMethods
    {
        public static Type MaxIssuedSupply<Type>(this IMaxIssuedSupplyFilterable<Type> maxIssuedSupplyFilterable, int maxIssuedSupply)
        {
            maxIssuedSupplyFilterable.AddQuery("max_issued_supply", maxIssuedSupply.ToString());
            return (Type)maxIssuedSupplyFilterable;
        }
    }

    public static class HasAssetsFilterableExtensionMethods
    {
        public static Type HasAssets<Type>(this IHasAssetsFilterable<Type> hasAssetsFilterable, bool hasAssets)
        {
            hasAssetsFilterable.AddQuery("has_assets", hasAssets.ToString());
            return (Type)hasAssetsFilterable;
        }
    }

    public static class MaxSupplyFilterableExtensionMethods
    {
        public static Type MaxSupply<Type>(this IMaxSupplyFilterable<Type> maxSupplyFilterable, int maxSupply)
        {
            maxSupplyFilterable.AddQuery("max_supply", maxSupply.ToString());
            return (Type)maxSupplyFilterable;
        }
    }

    public static class HideContractsFilterableExtensionMethods
    {
        public static Type HideContracts<Type>(this IHideContractsFilterable<Type> hideContractsFilterable, bool hideContracts)
        {
            hideContractsFilterable.AddQuery("hide_contracts", hideContracts.ToString());
            return (Type)hideContractsFilterable;
        }
    }

    public static class TransferFilterableExtensionMethods
    {
        public static Type Transfers<Type>(this ITransfersFilterable<Type> transfersFilterable, List<long> transfers)
        {
            transfersFilterable.AddMultiArgQuery("transfer_id", transfers.Select(t=>t.ToString()).ToList());
            return (Type)transfersFilterable;
        }
    }
}